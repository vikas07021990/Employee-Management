using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment
{
   public class TaskSheet
    {
        TaskSheet()
        {
            subTasks = new List<SubTask>();
        }
        public string taskId { get; set; }
        public string taskName { get; set; }
        public DateTime taskstartDate { get; set; }
        public DateTime taskEndDate { get; set; }
        public string taskDepartment { get; set; }
        public string taskClientName { get; set; }
        public string taskClientContact { get; set; }
        public string taskManager { get; set; }
        public string taskResponsible { get; set; }
        public bool isFinished { get; set; }
        public List<SubTask> subTasks { get; set; }

       public class SubTask
        {
            public string sub_task_name { get; set; }
            public string sub_task_employeeName { get; set; }
            public string sub_task_details { get; set; }
            public DateTime sub_task_startDate { get; set; }
            public DateTime sub_task_endDate { get; set; }
            public bool sub_task_isfinished { get; set; }
        }
    }
}
