using System;

namespace RefactoringExamples.ReplaceTypeCodeWithStateStrategy
{
    public class Employee
    {
        private readonly int _monthlySalary;
        private readonly int _commission;
        private readonly int _bonus;
        private EmployeeType _employeeType;
        public const int Engineer = 0;
        public const int Salesperson = 1;
        public const int Manager = 2;

        public Employee(int type)
        {
            Type = type;
            _monthlySalary = 100;
            _commission = 10;
            _bonus = 20;
        }

        public int Type
        {
            set { _employeeType = EmployeeType.FromCode(value); }
        }

        public int PayAmount()
        {
            return Pay();
        }

        private int Pay()
        {
            switch (_employeeType.Code)
            {
                case Engineer:
                    return _monthlySalary;
                case Salesperson:
                    return _monthlySalary + _commission;
                case Manager:
                    return _monthlySalary + _bonus;
                default:
                    throw new Exception("Incorrect Employee");
            }
        }
    }
}