CREATE TABLE _User(
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    user_type VARCHAR(20),
    user_name VARCHAR(20),
    user_password VARCHAR(20),
    email VARCHAR(20),
    phone_number INT, 
    address VARCHAR(20));

---------------------------------------------------

CREATE TABLE Item(
   item_id INT IDENTITY(1,1) PRIMARY KEY,
   item_name VARCHAR(20),
   item_type VARCHAR(20) DEFAULT 'Book', 
   publisher_name VARCHAR(20),
   author_name VARCHAR(20),
   author_id Int,
   _language VARCHAR(20) DEFAULT 'English',
   category VARCHAR(20),
   _year INT,
   price INT,
   available VARCHAR(3) check(available = 'yes' or available = 'no'),
   number_of_copies INT);

---------------------------------------------------

CREATE TABLE Authentication_system(
    login_id INT IDENTITY(1,1) PRIMARY KEY,
    admin_id INT foreign key references _User(user_id), 
    user-name VARCHAR(20),
    user-password VARCHAR(20));

-----------------------------------------------------

CREATE TABLE Purchase(
    purchase_id INT IDENTITY(1,1) PRIMARY KEY,
    purchase_Date DATE,
    item_id INT foreign key references Item(item_id),
    author_id INT foreign key references _User(user_id), 
    buyer_id INT foreign key references _User(user_id));

-----------------------------------------------------

CREATE TABLE student(
  student_id INT IDENTITY(1,1) PRIMARY KEY foreign key   references _User(user_id), 
university VARCHAR(20),
faculty VARCHAR(20),
specialization VARCHAR(20));

-------------------------------------------------------

CREATE TABLE Comment(
  comment_id INT IDENTITY(1,1) PRIMARY KEY,
  content VARCHAR(100),
  commenter_id INT foreign key references _User(user_id),
  item_id INT foreign key references Item(item_id));




           