using System;
using System.Collections.Generic;
using EuroData.Interfaces;

namespace EuroData.Classes.Entities
{
    public class Project
    {
        public int projectNumber;
        public string title;
        public double contractValue;
        public double paidAmount;
        public int totalHoursWorked;
        public DateTime start;
        public bool canceled;
#nullable enable
        public DateTime? end;
        public List<IStaffInterface>? staff;
        public IStaffInterface? responsible;

        public Project(int projectNumber, string title, double contractValue, double paidAmount, int totalHoursWorked, DateTime start, DateTime? end, bool canceled, List<IStaffInterface>? staff = null, IStaffInterface? responsible = null)
        {
            this.projectNumber = projectNumber;
            this.title = title;
            this.contractValue = contractValue;
            this.paidAmount = paidAmount;
            this.totalHoursWorked = totalHoursWorked;
            this.start = start;
            this.end = end;
            this.canceled = canceled;
            this.staff = staff;
            this.responsible = responsible;
        }

        public void addHoursWorked(int hours)
        {
            this.totalHoursWorked += hours;
        }

        public double getProjectValue()
        {
            if (canceled)
            {
                // return less than 0 because money was given back
                return -1;
            }

            if (totalHoursWorked == 0)
            {
                // only give value if some work is already done
                return 0;
            }
            return paidAmount / totalHoursWorked;
        }
    }
}