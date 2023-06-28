
# Welcome to the Bots-of-Midgard wiki with Explanation of Wa01!


### Project Models:
![image](https://github.com/yunusemree55/Bots-of-Midgard/assets/77694646/adcdecad-4c53-43ab-83d2-f0ef22de26e5)
![image](https://github.com/yunusemree55/Bots-of-Midgard/assets/77694646/bf7daa27-ebb8-4602-9a8a-00f323a60c4f)


`[JsonIgnore]` makes spesific field hide

All products have only one category but Category has many products. Which means that **1-M Relationship** between **Category** and **Product**.

----------------------------------------------------------------------------------------------------------------------------------------------

### Database Context:

![image](https://github.com/yunusemree55/Bots-of-Midgard/assets/77694646/8156b4cc-11b9-4e63-8d29-dd07371c9c59)

This context connect API to MSSQL and then we can use these methods which read, add , delete and update methods on API.




### ERD Diagram of Database

![image](https://github.com/yunusemree55/Bots-of-Midgard/assets/77694646/0580da68-2874-44cd-af53-b73e2b79b279)
 
Both table has **primary key** which column name is **Id**. Also Products table has **foreign key**. This key has relationship between Categories table




### ProductController:

![image](https://github.com/yunusemree55/Bots-of-Midgard/assets/77694646/4529716d-2de7-449a-bcc9-e17118005094)
![image](https://github.com/yunusemree55/Bots-of-Midgard/assets/77694646/97143c99-79bc-42b2-88b1-f3e990c9d02e)

### CategoryController:
![image](https://github.com/yunusemree55/Bots-of-Midgard/assets/77694646/4191009f-6b41-4829-896b-b41c7c17114d)
![image](https://github.com/yunusemree55/Bots-of-Midgard/assets/77694646/38e16f92-b385-44b2-8ff8-faf476a0fb8f)




![image](https://github.com/yunusemree55/Bots-of-Midgard/assets/77694646/5c4f3148-b15d-41d4-92d2-2e9b6983853a)


There are two models in this photo. We can use
* GET
* POST
* DELETE
* PUT

GET Method reads all data in database.
POST Method adds new data in database.
DELETE Method deletes specific data in database.
PUT Method updates data(s) in database
