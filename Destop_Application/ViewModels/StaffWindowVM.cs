using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Destop_Application.Data;
using Destop_Application.Models;
using Destop_Application.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Destop_Application.ViewModels
{
    public partial class StaffWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string firstName;

        [ObservableProperty]
        public string lastName;

        [ObservableProperty]
        public string nicNo;

        [ObservableProperty]
        public int maths;

        [ObservableProperty]
        public int physics;

        [ObservableProperty]
        public int chemistry;

        [ObservableProperty]
        public double average;




        [ObservableProperty]
        public ObservableCollection<Student> students;

        [ObservableProperty]
        public Student selectedstudent;

        [RelayCommand]
        public void InsertStudent()
        {
            double average = (maths + physics + chemistry) / 3.0;
            average = Math.Round(average, 2);
            Student p = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                NicNo = nicNo,
                Maths = maths,
                Physics = physics,
                Chemistry = chemistry,
                Average = average
            };
            students.Add(p);
            using (var db = new DataBaseContext())
            {
                db.Students.Add(p);
                db.SaveChanges();
                MessageBox.Show("Student successfully created");
            }

            LoadPerson();
        }

       

        [RelayCommand]
        public void Delete()
        {
            if (selectedstudent == null)
            {
                return;
            }
            else
            {
                using (var db = new DataBaseContext())
                {
                    var originalPerson = db.Students.FirstOrDefault(p => p.Id == selectedstudent.Id);
                    if (originalPerson != null)
                    {
                        db.Students.Remove(originalPerson);
                        db.SaveChanges();
                    }
                }
                Students.Remove(selectedstudent);
               
            }
            LoadPerson();
        }

        public void LoadPerson()
        {
            using (var db = new DataBaseContext())
            {
                students.Clear();
                var list = db.Students.OrderByDescending(p => p.Average).ToList();
                
                foreach (var student in list)
                {
                    students.Add(student);
                }
            }
        }

        [RelayCommand]
        public void EditStudent()
        {
            if (selectedstudent != null)
            {
                var window = new EditStudentWindow(selectedstudent);
                window.ShowDialog();


                //int index = students.IndexOf(selectedstudent);
                //students.RemoveAt(index);
                //students.Insert(index, st.Student);

            }
            else
            {
                MessageBox.Show("Please Select the student Before Edit", "Warning!!");
            }

        }








        [RelayCommand]
        public void Edit()
        {
            if (selectedstudent != null)
            {
                var editWindow = new EditStudentWindow(selectedstudent);
                editWindow.ShowDialog();


                if (editWindow.IsModified)
                {
                    double average = (selectedstudent.Maths + selectedstudent.Physics + selectedstudent.Chemistry) / 3.0;
                    average = Math.Round(average, 2);

                    selectedstudent.Average = average;
                    
                    using (var db = new DataBaseContext())
                    {
                        var originalStudent = db.Students.FirstOrDefault(s => s.Id == selectedstudent.Id);
                        if (originalStudent != null)
                        {
                            // Update the properties of the original student with the modified values
                            originalStudent.FirstName = selectedstudent.FirstName;
                            originalStudent.LastName = selectedstudent.LastName;
                            originalStudent.NicNo = selectedstudent.NicNo;
                            originalStudent.Physics = selectedstudent.Physics;
                            originalStudent.Maths = selectedstudent.Maths;
                            originalStudent.Chemistry = selectedstudent.Chemistry;
                            originalStudent.Average = average;

                            db.SaveChanges();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select the student Before Edit", "Warning!!");
            }
        }
       

        public StaffWindowVM()
        {
            students = new ObservableCollection<Student>();
            LoadPerson();
        }

    }




}

