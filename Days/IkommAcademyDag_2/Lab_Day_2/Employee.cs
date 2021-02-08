using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement
{
    class Employee
    {
        #region fields
        private string employeeName;
        private double salary;
        private DateTime joinDate;
        private string[] skills = new string[10];
        private int index = 0;
        #endregion

        #region props
        public string EmployeeName {
            get { return employeeName; }
            private set { employeeName = value;  }
            }

        public double Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        public DateTime JoinDate
        {
            get { return joinDate; }
            private set { joinDate = value; }
        }

        public string[] Skills
        {
            get { return skills; }
            private set { skills = value; }
        }

        private UserProfile UserInfo
        {
            get; set;
        }
        #endregion


        #region Constructor & overloads
        public Employee(string name, double salary, DateTime joindate, string[] skills)
        {
            UserInfo = new UserProfile(name);
            EmployeeName = name;
            Salary = salary;
            JoinDate = joindate;
            Skills = skills;
        }

        public Employee(string name="Firstname Lastname", double salary=100000.0, DateTime ?joindate = null)
        {
            UserInfo = new UserProfile(name);
            EmployeeName = name;
            Salary = salary;
            if (joindate is null)
            {
                JoinDate = DateTime.Now;
            } else
            {
                JoinDate = (DateTime)joindate;
            }
        }

        ~Employee()
        {
            Console.WriteLine($"Killed eployee {this.ToString()}");
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"{UserInfo} {Salary} {JoinDate.ToShortDateString()} {GetSkills()}";
        }

        public void UpdateUser()
        {
            SetEmail();  // Maybe better to make own "password" and "email" classes that deal with pasword change. Or include into property accessors.
            SetPassword();
        }

        private void SetPassword()
        {
            Console.Write("Update registered password? (y/n):");
            string result = Console.ReadLine().ToLower();
            if (result.Contains('y'))
            {
                bool gettingInput = true;
                while (gettingInput)
                {
                    try
                    {
                        gettingInput = PasswordChange();
                    }
                    catch (Exception err)
                    {
                        string errorValue = err.Message.ToString();
                        Console.WriteLine(errorValue);

                    }
                }
            } else
            {
                Console.WriteLine("Aborted password change");
            }
        }

        private bool PasswordChange()
        {
            /* Password update method
             * Prompts the user for the old password and then the new + confirmation.
             * If the two new passwords do not match or the supplied old password is inncorrect, trow error and retry
             */ 
            bool gettingInput;
            Console.Write("Please enter old password: ");
            string oldInputPassword = GetPasswordEntry();
            Console.Write("Please enter new password: ");
            string newInputPassword = GetPasswordEntry();
            Console.Write("Please re enter new password: ");
            string newInputPassword2 = GetPasswordEntry();
            if (newInputPassword != newInputPassword2) throw new Exception("The new password does not match!");
            if (!UserInfo.SetPassword(oldInputPassword, newInputPassword))
            {
                throw new Exception($"Given old password does not match or new password is null");
            }
            else
            {
                Console.WriteLine("Password changed sucessfully");
                gettingInput = false;
            }

            return gettingInput;
        }

        private static string GetPasswordEntry()
        {
            string builtPassword = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                builtPassword += key.KeyChar;
                Console.Write('*');
            }
            Console.WriteLine();
            return builtPassword;
        }

        private void SetEmail()
        {
            Console.Write("Update registered email adress? (y/n):");
            string result = Console.ReadLine().ToLower();
            if (result.Contains('y'))
            {
                bool gettingInput = true;
                while (gettingInput)
                {
                    gettingInput = GetEmailEntry(gettingInput);
                }
            }
            else
            {
                Console.WriteLine("Aborted email change");
            }
        }

        private bool GetEmailEntry(bool gettingInput)
        {
            try
            {
                Console.Write("Please enter a new email: ");
                string userResult = Console.ReadLine();
                if (userResult.Length <= 1) throw new Exception($"Too short to be a valid Email: {userResult}");
                if (!userResult.Contains('@')) throw new Exception($"Did you forget the '@'?");
                UserInfo.SetEmail(userResult);
                gettingInput = false;
            }
            catch (Exception err)
            {
                string errorValue = err.Message.ToString();
                Console.WriteLine(errorValue);

            }

            return gettingInput;
        }

        private string GetSkills()
        {
            string output = "Registered skills: ";
            foreach (var item in Skills)
            {
                if (item is null) continue;
                output += $"'{item}' ";
            }
            return output;
        }

        public bool Raise(double amount)
        {
            // Possibility to add logic to ensure salary is updated properly and return a exit code. 
            Salary += amount;
            return true;
        }

        public bool AddSkill(string skill)
        {
            // Bool for error handling etc.
            if (Skills.Length <= index) return false;
            Skills[index] = skill;
            index++;
            return true;
        }

        public bool AddSkill(params string[] skill) // Overload to add multiple skills at once
        {
            if ((Skills.Length + skill.Length) <= index) return false; //Check if the given array of skills will overflow the array
            foreach (var item in skill)
            {
                Skills[index] = item;
            }
            index += skill.Length;
            return true;
        }

        public bool RemoveSkill(string skillToRemove)
        {
            /* // "Conventional" method??
            int indexToRemove = Array.IndexOf(Skills, skillToRemove);
            if (indexToRemove != -1)
            {
                Skills[indexToRemove] = null;
            } else
            {
                return false;
            }*/
            int lenOfOldSkills = Skills.Length;
            Skills = Skills.Where(x => x != skillToRemove).ToArray(); //Using LINQ, too used to functional js I gues...
            index = Skills.Length;
            return (lenOfOldSkills != Skills.Length);
        }


        #endregion

    }
}
