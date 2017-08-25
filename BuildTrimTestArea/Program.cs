using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTrimTestArea {

    class Program {
        const int MINUTE = 60;
        const int HOUR = 60 * MINUTE;
        const int DAY = 24 * HOUR;
        const int WEEK = 7 * DAY;
        const int MONTH = 30 * DAY;
        const int YEAR = 365 * DAY;

        static void Main(string[] args) {
            var base_folder = Directory.CreateDirectory("./yard");
            FillFolder(base_folder);
            var child_1 = base_folder.CreateSubdirectory("first-child");
            FillFolder(child_1);
            var child_2 = child_1.CreateSubdirectory("second-child");
            FillFolder(child_2);
        }

        static void FillFolder(DirectoryInfo folder) {
            string base_path = folder.FullName + Path.DirectorySeparatorChar;

            CreateFile(base_path + "01-MinusOneSecond", -1);
            CreateFile(base_path + "02-MinusOneMinute", -MINUTE);
            CreateFile(base_path + "03-MinusFiveMinutes", -5 * MINUTE);
            CreateFile(base_path + "04-MinusTenMinutes", -10 * MINUTE);
            CreateFile(base_path + "05-MinusFifteenMinutes", -15 * MINUTE);
            CreateFile(base_path + "06-MinusThirtyMinutes", -30 * MINUTE);
            CreateFile(base_path + "07-MinusOneHour", -HOUR);
            CreateFile(base_path + "08-MinusTwoHours", -2 * HOUR);
            CreateFile(base_path + "09-MinusThreeHours", -3 * HOUR);
            CreateFile(base_path + "10-MinusFourHours", -4 * HOUR);
            CreateFile(base_path + "11-MinusSixHours", -6 * HOUR);
            CreateFile(base_path + "12-MinusEightHours", -8 * HOUR);
            CreateFile(base_path + "13-MinusTwelveHours", -12 * HOUR);
            CreateFile(base_path + "14-MinusOneDay", -DAY);
            CreateFile(base_path + "15-MinusTwoDays", -2 * DAY);
            CreateFile(base_path + "16-MinusThreeDays", -3 * DAY);
            CreateFile(base_path + "17-MinusOneWeek", -WEEK);
            CreateFile(base_path + "18-MinusTwoWeeks", -2 * WEEK);
            CreateFile(base_path + "19-MinusThreeWeeks", -3 * WEEK);
            CreateFile(base_path + "20-MinusOneMonth", -MONTH);
            CreateFile(base_path + "21-MinusTwoMonths", -2 * MONTH);
            CreateFile(base_path + "22-MinusThreeMonths", -3 * MONTH);
            CreateFile(base_path + "23-MinusFourMonths", -4 * MONTH);
            CreateFile(base_path + "24-MinusSixMonths", -6 * MONTH);
            CreateFile(base_path + "25-MinusOneYear", -YEAR);
            CreateFile(base_path + "26-MinusTwoYears", -2 * YEAR);
        }

        static void CreateFile(string path, int age) {
            DateTime date = DateTime.Now.AddSeconds(age);
            File.Create(path).Dispose();
            File.SetCreationTime(path, date);
            File.SetLastWriteTime(path, date);
        }

    }

}
