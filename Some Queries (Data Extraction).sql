--1-what is the most interesting book 'title' that has maximum number of buyers

select item_name from Item
where item_id in (select top 1 item_id
from Purthase
GROUP BY item_id
order by count(purchase_id) desc);

---------------------------------------------------------

--2-what was the book 'title' that hadn't any buyers last month

SELECT item_name FROM Item 
where item_id not  in(
SELECT item_id 
FROM Purthase 
where MONTH(Purthase.purchase_Date) = 4 
AND YEAR(Purthase.purchase_Date) = 2022);

----------------------------------------------------------------


--3-what is the number of authors whose books hadn't any buyers during last month

SELECT count(author_name) FROM Item 
where author_id not  in(
SELECT author_id FROM Purthase 
where MONTH(Purthase.purchase_Date) = 4 
AND YEAR(Purthase.purchase_Date) = 2022);

----------------------------------------------------------------

--4-who are the authors who didn't upload any books yet

Select user_name from _User 
where user_type = 'author' and user_id
not in(Select author_id from Item);

----------------------------------------------------------------

--5-what is the category with minimum number of books


SELECT top 1 category,count(category)as number_of_books
FROM Item
GROUP BY category
order by count(category) asc;

--------------------------------------------------------------

--6-for each reader, retrieve all his/her information 

SELECT Purthase.buyer_id AS ID,_User.user_name AS Name,_User.user_password AS password ,_User.email ,_User.phone_number ,_User.address,count(Purthase.buyer_id ) AS number_of_purchases 
FROM Purthase,_User
WHERE user_type = 'reader' AND Purthase.buyer_id =
_User.user_id
GROUP BY Purthase.buyer_id 
ORDER BY Purthase.buyer_id ASC;





