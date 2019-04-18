using System;
using System.Collections.Generic;

using SMS.Data.Models;

namespace SMS.Data.Services
{
    // This interface describes the operations for a StudentService class 
    public interface IStudentService
    {
        // User Management
        User GetUserByCredentials(string username, string password);
        User RegisterUser(string username, string password, Role role);

        // ...

        // Student / Ticket Management

        Module AddModule(Module m);
        Student AddStudent(Student s);
        Student GetStudent(int id);
        bool DeleteStudent(int id);
        Student UpdateStudent(Student s);
        Student RecalculateStudentGrade(int studentId);     //
        IList<Student> GetStudents();
        IList<Student> GetStudentsTakingModule(int moduleId);
        StudentModule AddStudentToModule(int studentId, int moduleId);
        StudentModule UpdateStudentModuleGrade(int studentId, int moduleId, double grade);
        bool RemoveStudentFromModule(int studentId, int moduleId);
        Ticket CreateTicket(int studentId, string issue);
        Ticket CloseTicket(int ticketId);
        IList<Ticket> GetActiveTickets();
        IList<Ticket> GetStudentTickets(int studentId);
        int ActiveTicketCount();
        int ActiveTicketCountForStudent(int studentId);
        int StudentCount();
        void Initialise();

    }
}
