using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            // 1. Hiển thị Menu
            DisplayMenu();

            // 2. Lấy lựa chọn từ người dùng
            string choice = Console.ReadLine();

            // 3. Xử lý lựa chọn
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    ManageProducts();
                    break;
                case "2":
                    Console.Clear();
                    ManageCustomers();
                    break;
                case "3":
                    Console.Clear();
                    GenerateReport();
                    break;
                case "4":
                    isRunning = false;
                    Console.WriteLine("Đang thoát ứng dụng...");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }

            Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    /// <summary>
    /// Hiển thị các mục menu cho người dùng.
    /// </summary>
    static void DisplayMenu()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("|       QUẢN LÝ BÁN HÀNG (Console)       |");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("| 1. Quản lý Sản phẩm                    |");
        Console.WriteLine("| 2. Quản lý Khách hàng                  |");
        Console.WriteLine("| 3. Báo cáo Doanh thu                   |");
        Console.WriteLine("| 4. Thoát                               |");
        Console.WriteLine("------------------------------------------");
        Console.Write("Vui lòng nhập lựa chọn của bạn: ");
    }

    /// <summary>
    /// Chức năng Quản lý Sản phẩm.
    /// </summary>
    static void ManageProducts()
    {
        Console.WriteLine(">>> Bạn đã chọn Quản lý Sản phẩm <<<");
        Console.WriteLine("Chức năng này sẽ được phát triển sau...");
        // Ở đây, bạn có thể thêm logic để hiển thị danh sách sản phẩm, thêm, sửa, xóa...
    }

    /// <summary>
    /// Chức năng Quản lý Khách hàng.
    /// </summary>
    static void ManageCustomers()
    {
        Console.WriteLine(">>> Bạn đã chọn Quản lý Khách hàng <<<");
        Console.WriteLine("Chức năng này sẽ được phát triển sau...");
        // Tương tự, bạn có thể thêm logic cho khách hàng ở đây.
    }

    /// <summary>
    /// Chức năng Báo cáo Doanh thu.
    /// </summary>
    static void GenerateReport()
    {
        Console.WriteLine(">>> Bạn đã chọn Báo cáo Doanh thu <<<");
        Console.WriteLine("Chức năng này sẽ được phát triển sau...");
        // Logic tạo báo cáo sẽ nằm ở đây.
    }
}