**Online Quiz Management System**

The **Online Quiz Management System** is a web-based mini project developed using **ASP.NET** and **SQL Server**. This system is designed to make the process of conducting and attempting quizzes digital, efficient, and user-friendly.

It provides two main interfaces — a **Student Page** for attempting quizzes and an **Admin Panel** for managing quiz questions. The project focuses on integrating backend database operations with a dynamic web interface, enabling smooth interaction between users and stored data.

**Project Overview**

The **Student Page** allows users to directly attempt a quiz consisting of multiple-choice questions. After answering all questions, the student submits the quiz and is immediately redirected to a **Results Page**, where the system automatically evaluates responses and displays the score along with correct answers. This ensures instant feedback and eliminates manual checking.

On the **Admin side**, there is a secure **Admin Login Page** to restrict unauthorized access. Once logged in, the admin can manage the quiz content through a dedicated **Admin Panel**. The admin can perform full **CRUD operations** —

 **Add** new questions
 **Edit or Update** existing questions
 **Delete** questions if needed

All these actions are directly reflected in the connected database, ensuring real-time updates for the student side.



 **Database Design**

The system uses **SQL Server** with the following key tables:

 **Admins Table** – stores administrator login credentials.
 **Quiz Table** – stores quiz questions, multiple-choice options, and the correct answer.

These tables are linked through ASP.NET to provide a seamless experience between the user interface and database operations.
![admin login](https://github.com/user-attachments/assets/8c293eec-ee59-41e5-b7eb-8f91b0a95c95)
![create](https://github.com/user-attachments/assets/cf0910a7-7872-4901-89da-bad604fb0a5c)
![quiz ](https://github.com/user-attachments/assets/cef92fb5-ad27-4c11-990b-ebedb8af38e5)
![edit](https://github.com/user-attachments/assets/a7a6a421-c54c-403a-bae3-ad0f50ee13c9)      
![result](https://github.com/user-attachments/assets/16f5b754-10eb-443c-bdff-28226f683652)



**Key Learning Areas**

This project demonstrates practical understanding of **ASP.NET web development**, **database connectivity**, and **CRUD operations**. It showcases how a simple yet functional online system can manage quizzes, process results instantly, and provide an efficient platform for both students and administrators.

