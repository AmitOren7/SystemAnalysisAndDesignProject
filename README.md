# **System Analysis and Design Project**

This project is part of a course focusing on analyzing, designing, and implementing an information system.
The project was developed collaboratively by a team of four students and involves designing a system for "Sammy Cranes," a company specializing in transportation and crane services.
- Amit Oren
- Leah Rosen
- Eden Cohen
- Romi Mali

---

## **Technologies Used**
- **SQL Server Management Studio (SSMS)**: For database design and implementation.
- **Visual Studio**: For developing the application interface and logic.
- **Languages**:
  - **C#**: For backend development and application functionality.
  - **SQL**: For database queries and procedures.

---

## **Installation and Execution Instructions**
Follow these steps to set up and run the project:

1. **Install Required Software**:
   - Download and install **SSMS** and **Visual Studio**.

2. **Set Up the Database and Populate the Database**:
   - Execute the SQL script called `init_database.sql` provided in the repository to create the database schema and populate the schema.

3. **Run the Application**:
   - Open the solution file (`.sln`) in Visual Studio.
   - Build and run the application.
   - Use the login feature to access the system based on different user roles (details below).


The system models four roles:</br>
1. **Clerk** -  
     username: annalevi  
     password: securePass123  
2. **Driver** -  
     username: davidwilson  
     password: password159  
3. **Office Manager**  
     username: WorldBestBoss  
     password: password 
4. **Operations Manager**  
     username: galinda14  
     password: glgl4747  

## Troubleshooting
if you encore a problem `Couldn't process file .redx due to its being in the internet or Restricted Zone or having the mark of the web on the file. Remove the mark of the web if you want to process these files.`
open the folder in powershell and run `gci -recurse | Unblock-File`
