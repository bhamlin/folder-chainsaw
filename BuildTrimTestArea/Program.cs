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
        }

        static void FillFolder(DirectoryInfo folder) {
            string base_path = folder.FullName + Path.DirectorySeparatorChar;
            string file_name;

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
        }

        static void CreateFile(string path, int age) {
            DateTime date = DateTime.Now.AddSeconds(age);
            File.Create(path).Dispose();
            File.SetCreationTime(path, date);
            File.SetLastWriteTime(path, date);
        }

    }

}
