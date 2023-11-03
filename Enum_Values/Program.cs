using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Color myColor = Color.Green;
            Season Season = Season.Autumn;
            Console.WriteLine(Season);
            Console.WriteLine("Bạn vừa chọn màu: " + myColor);
            Console.ReadKey();
        }
        //VD1
        enum Color
        {
            Red,
            Green,
            Blue,
            Yellow
        }
        //VD2
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
    }
}

// enum là một "lớp" đặc biệt đại diện cho một nhóm các hằng số (biến không thể thay đổi/chỉ đọc)
// là từ khóa dùng để khai báo 1 kiểu liệt kê
// kiểu liệt kê là một tập hợp các hằng số do người dùng tự định nghĩa
// hỗ trợ người dùng gom nhóm các hằng số lại với nhau

//Đặc điểm
/*
 * Là một kiểu dữ liệu tham trị
 * không được phép kế thừa
 */
// Cú pháp và khai báo:
/*
 * enum <tên enum>
 * {
 *  <danh sách các biểu tượng hằng>
 * }
 * Trong đó:
 * - <tên enum> là tên kiểu liệt kê do mình tự đặt và tuân thủ theo quy tắc đặt tên
 * - <danh sách các biểu tượng hằng> là danh sách các biểu tượng hằng thành phần, mỗi biểu tượng hằng cách nhau bằng dấu ","
 */
//Sử dụng:
/*
 * Ta có thể truy xuất đến từng biểu tượng hằng của enum thông qua toán tử "." kèm theo biểu tượng hằng muốn truy xuất
 * VD: Color.Red;
 */