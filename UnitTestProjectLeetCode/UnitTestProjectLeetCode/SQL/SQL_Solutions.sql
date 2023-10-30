-- Big Countries
select name, population, area from World where area>=3000000 OR population>=25000000

-- Article Views I
select distinct author_id id 
from Views 
where 
author_id=viewer_id 
order by 
id asc

-- Invalid Tweets
select tweet_id  
from Tweets
where len(content)>15

-- Replace Employee ID With The Unique Identifier
select eU.unique_id, e.name 
from 
Employees e
left join 
EmployeeUNI eU on e.id=eU.id

-- Product Sales Analysis I subselect faster than join 
select 
  (select product_name from Product where product_id=s.product_id) product_name, s.year, s.price  
from 
  Sales s

-- Customer Who Visited but Did Not Make Any Transactions
select 
    customer_id,
    COUNT(*) count_no_trans 
from
    visits v
where 
    visit_id not in (select visit_id from Transactions)
group by 
    customer_id

-- Rising Temperature
select 
    id
from
    Weather w
where
    temperature >(select temperature from weather where recordDate = DATEADD(day,-1,w.recordDate))

-- Average Time of Process per Machine
SELECT 
    a1.machine_id, 
    ROUND(AVG(ABS(a1.timestamp - a2.timestamp)),3) AS processing_time
FROM 
    (SELECT *
     FROM Activity
     WHERE activity_type = 'start') a1,
    (SELECT *
     FROM Activity
     WHERE activity_type = 'end') a2
WHERE 
	a1.machine_id = a2.machine_id AND a1.process_id = a2.process_id
GROUP BY a1.machine_id;

-- Employee Bonus
select 
    e.name,
    b.bonus
from 
    Employee e
left join 
     Bonus b on b.empId = e.empId
where 
     b.bonus<1000 OR  b.bonus is NULL

-- Students and Examinations
select
	s.student_id,
	s.student_name ,
	sb.subject_name, 
	(select COUNT(*) from Examinations where student_id = s.student_id AND subject_name = sb.subject_name) attended_exams
from 
	Students s,
	Subjects sb
order by 
	student_id, subject_name

-- Confirmation Rate
select 
 sp.user_id,
 ROUND((ISNULL(sp.confCount* 1.0/NULLIF(sp.allConfCount, 0),0)),2) confirmation_rate 
 from
(select
	s.user_id,
	(select COUNT(*) from Confirmations where user_id = s.user_id) allConfCount,
	(select COUNT(*) from Confirmations where user_id = s.user_id AND action='confirmed') confCount
from 
	Signups s) sp

-- Not Boring Movies
select *
from 
    Cinema 
where
	description!='boring' and id%2!=0
order by 
	rating desc

-- Average Selling Price
select distinct
	rr.product_id,
	SUM(avg_price) average_price
from
	(select distinct
		sp.product_id,
		ROUND( ISNULL(SUM(sp.purchase) over(PARTITION BY sp.product_id) / NULLIF((totalUnits* 1.0),0),0) ,2) avg_price 
	from
	(select 
		ps.product_id,
		ISNULL(us.units * (select price from Prices where product_id=us.product_id AND  us.purchase_date BETWEEN start_date AND end_date),0) purchase,
		ISNULL(SUM(us.units) over(PARTITION BY us.product_id),0) totalUnits	
	from 
		Prices ps
		left join UnitsSold us on ps.product_id=us.product_id AND  (us.purchase_date BETWEEN start_date AND end_date)) sp) rr
group by rr.product_id

-- Project Employees I
SELECT 
    p.project_id, ROUND(AVG(e.experience_years*1.0),2) AS average_years
FROM Project p 
LEFT JOIN Employee e
ON p.employee_id = e.employee_id
GROUP BY p.project_id

-- Percentage of Users Attended a Contest
DECLARE @count	INT

SELECT @count = COUNT(*)
  FROM Users  (NOLOCK)

select 
  ids.contest_id, 
  Round(((ids.cnt_rr*1.00)/@count)*100,2) percentage 
from
(select distinct contest_id,
  count(*) over (partition by contest_id) cnt_rr
  from Register) ids 
order by 
  percentage desc,
  contest_id asc

-- Queries Quality and Percentage
select
    query_name,
    round(avg(cast(rating as decimal) / position), 2) as quality,
    round(sum(case when rating < 3 then 1 else 0 end) * 100*1.00 / count(*), 2) as poor_query_percentage
from
    queries
group by
    query_name;
	
-- Monthly Transactions I
select
    LEFT(trans_date,7) month
    ,country
    ,count(*) trans_count
    ,sum(case when state ='approved' then 1 else 0 end) approved_count
    ,SUM(amount) trans_total_amount 
    ,sum(case when state ='approved' then amount else 0 end) approved_total_amount
from 
    Transactions    
group by 
    LEFT(trans_date,7), country

-- Immediate Food Delivery II
select 
    Round((Count(*)*1.00/(select COUNT(distinct customer_id) from Delivery))*100,2) immediate_percentage
from
    Delivery t,
    (select 
        customer_id
        ,MIN(order_date) min_ordDate
    from
        Delivery
    group by 
        customer_id)  test      
where 
    t.customer_id = test.customer_id AND test.min_ordDate = t.order_date AND test.min_ordDate = t.customer_pref_delivery_date 

-- Game Play Analysis IV
Select 
   Round(Count(distinct t.player_id)*1.00/((select COUNT(distinct player_id) from Activity)),2) fraction
FROM
    (SELECT 
            player_id
            ,event_date
            ,LAG(event_date,1) OVER (PARTITION BY player_id ORDER BY player_id, event_date) prev_event_date
            ,LAG(player_id,1) OVER (PARTITION BY player_id ORDER BY player_id, event_date) prev_player_id
    FROM
        Activity) t
where 
    t.player_id = t.prev_player_id
    AND
    t.event_date = dateadd(day, 1, t.prev_event_date)
    AND
    t.prev_event_date = (Select min(event_date) from Activity where t.player_id = player_id)

-- Number of Unique Subjects Taught by Each Teacher
select
    teacher_id
    , Count(distinct subject_id) cnt 
from
    Teacher
group by
    teacher_id

-- User Activity for the Past 30 Days I
select
    activity_date day
    ,count(distinct user_id) active_users
from 
    Activity
where
    activity_date <'2019-07-27' AND activity_date >dateadd(day, -30, '2019-07-27')
group by
    activity_date

-- Product Sales Analysis III (may be need CTE but the same de facto)
Select 
    s.product_id
    ,s.year first_year 
    ,s.quantity 
    ,s.price 
from
    Sales s,
    (select 
        product_id
        ,MIN(year) min_year
    from
        Sales
    GROUP BY
        product_id) t
where
    s.product_id= t.product_id AND t.min_year=s.year

-- Classes More Than 5 Students
select 
    t.class
from
(select
    class
    ,Count(student) cnt
from
    Courses
group by 
    class) t   
where
    t.cnt > 4

-- Biggest Single Number
select
    max(t.num) num
from
    (select distinct
        num,
        (select count(num) from MyNumbers where t.num = num) cnt
    from 
        MyNumbers t) t
where 
    t.cnt = 1

-- Customers Who Bought All Products
DECLARE @count	INT

SELECT @count = COUNT(*)
  FROM Product  (NOLOCK)

select 
    customer_id
from
    (select 
        customer_id
        ,count(distinct product_key) product_count
    from
        Customer 
    group by 
        customer_id) t
where 
    t.product_count = @count

-- The Number of Employees Which Report to Each Employee
select 
    e.employee_id
    ,e.name  
    ,t.reports_count
    ,ROUND(t.average_age, 0) average_age
from 
   Employees e 
   join    
(select
    reports_to
    ,AVG(age*1.0) average_age
    ,COUNT(*) reports_count
from 
    Employees
group by
    reports_to
    ) t on t.reports_to = e.employee_id


-- Primary Department for Each Employee
SELECT 
  employee_id, 
  department_id 
FROM 
  (
    SELECT 
      *, 
      COUNT(employee_id) OVER(PARTITION BY employee_id) AS EmployeeCount
    FROM 
      Employee
  ) EmployeePartition 
WHERE 
  EmployeeCount = 1 
  OR primary_flag = 'Y';

-- Primary Department for Each Employee
select
    x,
    y,
    z,
    (CASE
        WHEN (x + y > z
                 AND
              x + z > y
                 AND
              y + z > x) THEN 'Yes'
        ELSE 'No'
    END) triangle
from
    Triangle

-- Consecutive Numbers
select distinct
    t.l1 ConsecutiveNums
from
   (select 
		  num l1
		  ,LEAD(num,1) OVER (order by id) l2
		  ,LEAD(num,2) OVER (order by id) l3
   from
		  Logs) t
where
     t.l1=t.l2 AND t.l2=t.l3
	 
-- Product Price at a Given Date
SELECT T.product_id , ISNULL( P.new_price , 10 ) AS price 
FROM (
    SELECT product_id , MAX(
        CASE WHEN 
          CAST( change_date  AS DATE) <= CAST('2019-08-16'  AS DATE )
        THEN change_date END
    ) AS dt
    FROM Products
    GROUP BY product_id
) AS T 
LEFT JOIN Products P
ON P.product_id = T.product_id AND T.dt = P.change_date;

-- Last Person to Fit in the Bus
WITH my_cte AS 
(SELECT 
      t1.person_name,
      t1.weight,
      SUM(t2.weight) AS cumulativeSum
FROM Queue t1
INNER JOIN Queue t2 ON t1.turn >= t2.turn
GROUP BY 
		t1.turn,
    t1.weight,
    t1.person_name
)

select top 1 person_name from  my_cte   
where cumulativeSum <= 1000
order by cumulativeSum desc

-- Count Salary Categories
select
    'Low Salary' category
    ,(sum(CASE
            WHEN income < 20000 THEN 1
            ELSE 0
          END)) accounts_count
from
    Accounts a1
UNION ALL
select
    'Average Salary' category
    ,(sum(CASE
            WHEN income >= 20000 AND income <= 50000  THEN 1
            ELSE 0
          END)) accounts_count
from
    Accounts a2
UNION ALL
select
    'High Salary' category
    ,(sum(CASE
            WHEN income > 50000 THEN 1
            ELSE 0
          END)) accounts_count
from
    Accounts a3

-- Employees Whose Manager Left the Company
SELECT 
    t1.employee_id
FROM 
    Employees t1
where
    t1.manager_id is not null
    AND
    t1.salary < 30000
    AND 
    NOT EXISTS(select 1 test from Employees where employee_id=t1.manager_id)
order by
    t1.employee_id

-- Exchange Seats
select 
    ROW_NUMBER() OVER(ORDER BY (SELECT 0)) AS id 
    ,ISNULL((select student from Seat where id=t.id1),(select student from Seat where id=t.id)) AS student 
from 
(select 
    id,
    (CASE
        WHEN (id % 2) = 0 THEN id-1
            ELSE id+1
    END) id1
from
    Seat) t

-- Movie Rating
SELECT username AS results
FROM (SELECT TOP 1 u.name AS username, COUNT(u.user_id) AS num_ratings
        FROM Users u
        JOIN MovieRating mr
            ON u.user_id = mr.user_id
        GROUP BY u.name
        ORDER BY num_ratings DESC, username) sq1
UNION ALL
SELECT movie_title AS results
FROM (SELECT TOP 1 m.title AS movie_title, AVG(mr.rating*1.0) AS avg_rating
        FROM Movies m
        JOIN MovieRating mr
            ON m.movie_id = mr.movie_id
        WHERE mr.created_at >= '2/1/2020'
            AND mr.created_at <= '2/29/2020'
        GROUP BY m.title
        ORDER BY avg_rating DESC, title) sq2

-- Restaurant Growth
with cte as (
  select visited_on, sum(amount) as amount
  from Customer
  group by visited_on
)

select 
    C1.visited_on as visited_on, 
    SUM(C2.amount) as amount, 
    ROUND(SUM(C2.amount*1.0)/7.0,2) as average_amount
from cte C1
join cte C2 ON DATEDIFF(day, C2.visited_on, C1.visited_on) BETWEEN 0 AND 6
where C1.visited_on >= (
  select DATEADD(day, 6, MIN(visited_on))
  from Customer
)
group by  C1.visited_on

-- Friend Requests II: Who Has the Most Friends
with cte as (
    select 
        t.id
        ,SUM(t.cnt_) sum1
    from
    (select 
        requester_id id
        ,Count(*) cnt_
    from 
        RequestAccepted
    group by 
        requester_id
    UNION ALL
    select 
        accepter_id id
        ,Count(*) cnt_
    from 
        RequestAccepted
    group by 
        accepter_id) t
    group by
    t.id)

select top 1
    id,
    sum1 num
from
    cte
order by sum1 desc

-- Investments in 2016
WITH CTE AS (
		SELECT
			*,
			COUNT(lat) OVER(PARTITION BY lat,lon) CountLatLon,
			COUNT(tiv_2015) OVER(PARTITION BY tiv_2015) CountT_2015
		FROM
			Insurance T1
)
SELECT
	ROUND(SUM(tiv_2016),2) tiv_2016 
FROM
	CTE
WHERE
	CountLatLon = 1
AND
	CountT_2015 > 1

-- Department Top Three Salaries
SELECT 
    d.name Department, 
    co.name Employee, 
    co.salary Salary 
FROM Employee co
inner join Department d  on co.departmentId = d.id
WHERE 
    (
        SELECT 
            COUNT(distinct ci.salary)
        FROM Employee ci
        WHERE  co.departmentId  = ci.departmentId  		-- controlling grouping column
        AND co.salary <= ci.salary 						-- controlling top or bottom 
    ) <= 3
order by 
    co.departmentId, co.salary desc

-- Fix Names in a Table
SELECT 
	user_id
	,UPPER(LEFT(name,1))+LOWER(SUBSTRING(name, 2,len(name))) name
FROM
	Users
order by user_id

-- Patients With a Condition
select
    patient_id
    ,patient_name
    ,conditions
from
    Patients
where
    conditions like '% DIAB1%' OR conditions like 'DIAB1%'

-- Delete Duplicate Emails
DELETE FROM Person WHERE id NOT IN 
( SELECT MIN(id) FROM Person GROUP BY email)

-- List the Products Ordered in a Period
WITH CTE AS (select
                product_id
                ,order_date
                , unit
            from
                Orders
            where
                order_date between '2020-02-01' and '2020-02-29'
)

SELECT
	(select product_name from Products where  cc.product_id=product_id) product_name
    ,SUM(cc.unit) unit
FROM
	CTE cc
Group By
	cc.product_id
HAVING 
    SUM(cc.unit) >= 100
	
-- Find Users With Valid E-Mails
select 
    *
from 
    Users
WHERE 
    mail LIKE '[a-zA-Z]%@leetcode.com' 
    AND LEFT(mail, LEN(mail) - 13) NOT LIKE '%[^0-9a-zA-Z_.-]%'

-- Second Highest Salary
DECLARE @maxSalary	INT

SELECT @maxSalary = MAX(salary) FROM Employee  (NOLOCK) 
  
select
    MAX(salary) SecondHighestSalary 
from
    Employee
where 
    id not in (select id from Employee where salary = @maxSalary)

-- Group Sold Products By The Date
WITH CTE AS (select distinct
                sell_date
                ,product
            from
                Activities
)

select 
    sell_date
    ,Count(product) num_sold
    ,STRING_AGG(product, ',') WITHIN GROUP (ORDER BY product ASC) products
from
    CTE
group by
    sell_date   