**🧠 Online Quiz Management System**

The **Online Quiz Management System** is a web-based mini project developed using **ASP.NET** and **SQL Server**. This system is designed to make the process of conducting and attempting quizzes digital, efficient, and user-friendly.

It provides two main interfaces — a **Student Page** for attempting quizzes and an **Admin Panel** for managing quiz questions. The project focuses on integrating backend database operations with a dynamic web interface, enabling smooth interaction between users and stored data.

**🎯 Project Overview**

The **Student Page** allows users to directly attempt a quiz consisting of multiple-choice questions. After answering all questions, the student submits the quiz and is immediately redirected to a **Results Page**, where the system automatically evaluates responses and displays the score along with correct answers. This ensures instant feedback and eliminates manual checking.

On the **Admin side**, there is a secure **Admin Login Page** to restrict unauthorized access. Once logged in, the admin can manage the quiz content through a dedicated **Admin Panel**. The admin can perform full **CRUD operations** —

 **Add** new questions
 **Edit or Update** existing questions
 **Delete** questions if needed

All these actions are directly reflected in the connected database, ensuring real-time updates for the student side.



 **🗄️ Database Design**

The system uses **SQL Server** with the following key tables:

 **Admins Table** – stores administrator login credentials.
 **Quiz Table** – stores quiz questions, multiple-choice options, and the correct answer.

These tables are linked through ASP.NET to provide a seamless experience between the user interface and database operations.


**⚙️ Admin Login**
![admin login](https://github.com/user-attachments/assets/3409eb8e-ff78-420f-96ff-79a5fdbe305c)



**🧩 Manage Quiz**
![manage](https://github.com/user-attachments/assets/66bf7ba1-6009-4dc0-9cc4-22d555e25cdb)



**➕ Create Quiz**
![create](https://github.com/user-attachments/assets/a340e3fd-23ce-47b5-ab8c-3b21b213b90d)



**✏️ Edit**
![edit](https://github.com/user-attachments/assets/66bc4f78-8b98-4fe6-ad02-023e235acfca)



**❌ Delete Quiz Question**
![delete](https://github.com/user-attachments/assets/8e4e7605-9f4c-4ccb-9947-c071f83d415a)



**Quiz**
![quiz ](https://github.com/user-attachments/assets/fd8f8c95-680b-4e62-b3f5-aae233e87727)



**📊 View Results**
![result](https://github.com/user-attachments/assets/5a9de342-ade0-427c-b93e-ebfafe0f509f)



**Video**
https://github.com/user-attachments/assets/19dfa03e-0c46-4480-81b2-b592d32e7eae




**💡Key Learning Areas**

This project demonstrates practical understanding of **ASP.NET web development**, **database connectivity**, and **CRUD operations**. It showcases how a simple yet functional online system can manage quizzes, process results instantly, and provide an efficient platform for both students and administrators.
