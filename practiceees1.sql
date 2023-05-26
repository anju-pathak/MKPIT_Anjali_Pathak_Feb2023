select * from salesmans1
select * from orderr
select * from customer
--------2. From the following tables write a SQL query to find those orders, which are higher than the average
------amount of the orders. Return ord_no, purch_amt, ord_date, customer_id and salesman_id.
select ord_no, purch_amt, ord_date, customer_id ,salesman_id from orderr a
where purch_amt>(select avg(purch_amt)from orderr b where b.customer_id=a.customer_id)
--13. From the following tables write a SQL query to find those orders that are equal or higher than the
--average amount of the orders. Return ord_no, purch_amt, ord_date, customer_id and salesman_id.
select ord_no, purch_amt, ord_date, customer_id ,salesman_id from orderr a where purch_amt>=(select avg(purch_amt)
from orderr b where a.customer_id=b.customer_id);





--14. Write a query to find the sums of the amounts from the orders table, grouped by date, and eliminate
--all dates where the sum was not at least 1000.00 above the maximum order amount for that date.
select ord_date ,sum(purch_amt)
from orderr a
group by ord_date
having sum(purch_amt)>
(select 1000+max(purch_amt)
from orderr b
where a.ord_date=b.ord_date);
----15. Write a query to extract all data from the customer table if and only if one or more of the customers in
---the customer table are located in London.
select * from customer where city='london'
--From the following tables write a SQL query to find salespeople who deal with multiple customers.
--Return salesman_id, name, city and commission.
select * from salesmans1 where (salesman_id>1) 
SELECT *
FROM salesmans1
WHERE salesman_id IN (SELECT salesman_id FROM customer GROUP BY salesman_id HAVING COUNT(salesman_id) > 1)
--From the following tables write a SQL query to find salespeople who deal with a single customer.
--Return salesman_id, name, city and commission.
select * from salesmans1 where salesman_id in(select salesman_id from customer group by salesman_id having 
count(salesman_id)=1)


select * from salesmans1 where salesman_id in(select salesman_id from orderr group by salesman_id having 
count(salesman_id)>1)From the orders table, find all those orders whose order amount greater than at least one of the orders of September 10th 2012. Return ord_no, purch_amt, ord_date, customer_id and salesman_id.

--From the orders table, find all those orders whose order amount greater than at least one of the orders of September 10th 2012. Return ord_no, purch_amt, ord_date, customer_id and salesman_id.
SELECT *
FROM orderr
WHERE purch_amt > ANY(SELECT purch_amt FROM orderr WHERE ord_date = ‘2012–09–10’)
select * from orderr
--19. From the customer and salesman tables, find the salespeople who deals those customers who live in the same city. Return salesman_id, name, city and commission.
select * from salesmans1 where city=any(select city from customer)
--From the customer and salesman tables, find the salespeople whose place of living (city) matches with any of the city where customers live. Return salesman_id, name, city and commission.
select * from salesmans1 where city in(select city from customer)
