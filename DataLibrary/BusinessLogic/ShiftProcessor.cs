using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;
using System.Collections.Generic;

namespace DataLibrary.BusinessLogic
{
    public static class ShiftProcessor
    {
        // Create new shift
        public static int CreateShift(int shiftId, string shiftRole, string shiftStart, 
            string shiftEnd, int empId)
        {

            ShiftModel data = new ShiftModel
            {
                ShiftID = shiftId,
                ShiftRole = shiftRole,
                ShiftStart = shiftStart,
                ShiftEnd = shiftEnd,
                EmployeeID = empId

            };

            string sql = @"insert into dbo.Shifts (ShiftId, ShiftRole, ShiftStart, ShiftEnd, EmployeeId)
                            values (@ShiftID, @ShiftRole, @ShiftStart, @ShiftEnd, @EmployeeID);";

            return SQLDataAccess.SaveData(sql, data);
        }



        public static List<ShiftModel> LoadShifts(int id)
        {
           
            string sql = @"select * from dbo.Shifts where EmployeeId in @data";

            List<ShiftModel> loadedShifts = SQLDataAccess.LoadShifts<ShiftModel>(sql, id);

            return loadedShifts;

        }


    }
}
