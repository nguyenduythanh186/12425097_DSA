using System;
using System.Text;

namespace BaiTapApDungChuong4
{

    // CẤU TRÚC DỮ LIỆU CHO BÀI 2 (STRUCT NHÂN VIÊN)

    struct NhanVien
    {
        public string MaNV;
        public string Hoten;
        public int Namsinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;
        public int ThucLinh => LuongCB + Thuong;
    }


    // CẤU TRÚC DỮ LIỆU CHO BÀI 4 & 5 (DSLK ĐƠN)

    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    class DanhSachLienKetDon
    {
        public Node pHead;

        public DanhSachLienKetDon()
        {
            pHead = null;
        }

        // Thêm vào cuối danh sách để giữ đúng thứ tự nhập
        public void ThemCuoi(int x)
        {
            Node newNode = new Node(x);
            if (pHead == null)
            {
                pHead = newNode;
                return;
            }
            Node p = pHead;
            while (p.Next != null)
            {
                p = p.Next;
            }
            p.Next = newNode;
        }

        public void XuatDanhSach()
        {
            if (pHead == null)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }
            Node p = pHead;
            while (p != null)
            {
                Console.Write(p.Data + " -> ");
                p = p.Next;
            }
            Console.WriteLine("null");
        }

        // --- CÁC HÀM BÀI 4 ---
        public int DemBangX(int x)
        {
            int d = 0;
            Node p = pHead;
            while (p != null)
            {
                if (p.Data == x) d++;
                p = p.Next;
            }
            return d;
        }

        public int TimMinDuong()
        {
            int minDuong = int.MaxValue;
            Node p = pHead;
            while (p != null)
            {
                if (p.Data > 0 && p.Data < minDuong)
                    minDuong = p.Data;
                p = p.Next;
            }
            return minDuong == int.MaxValue ? -1 : minDuong;
        }

        public bool XoaDauTienBangX(int x)
        {
            if (pHead == null) return false;

            // Trường hợp 1: pHead là nút cần xóa
            if (pHead.Data == x)
            {
                pHead = pHead.Next;
                return true;
            }

            // Trường hợp 2 & 3: Nút nằm ở giữa hoặc cuối
            Node t = pHead;
            Node p = pHead.Next;
            while (p != null && p.Data != x)
            {
                t = p;
                p = p.Next;
            }

            if (p != null) // Tìm thấy
            {
                t.Next = p.Next;
                return true;
            }
            return false;
        }

        // --- CÁC HÀM BÀI 5 ---
        public int TimMax()
        {
            if (pHead == null) return int.MinValue;
            int max = int.MinValue;
            Node p = pHead;
            while (p != null)
            {
                if (p.Data > max) max = p.Data;
                p = p.Next;
            }
            return max;
        }

        public int TinhTong()
        {
            int tong = 0;
            Node p = pHead;
            while (p != null)
            {
                tong += p.Data;
                p = p.Next;
            }
            return tong;
        }

        private bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public int DemSoNguyenTo()
        {
            int dem = 0;
            Node p = pHead;
            while (p != null)
            {
                if (LaSoNguyenTo(p.Data)) dem++;
                p = p.Next;
            }
            return dem;
        }

        public void DemAmDuongKhong(out int am, out int duong, out int khong)
        {
            am = duong = khong = 0;
            Node p = pHead;
            while (p != null)
            {
                if (p.Data < 0) am++;
                else if (p.Data > 0) duong++;
                else khong++;
                p = p.Next;
            }
        }
    }

    // ==========================================
    // CHƯƠNG TRÌNH CHÍNH
    // ==========================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n================ MENU BÀI TẬP ÁP DỤNG ================");
                Console.WriteLine("1. Bài tập 1: Mảng 1 chiều số nguyên dương & chèn phần tử");
                Console.WriteLine("2. Bài tập 2: Quản lý danh sách Nhân viên (Struct)");
                Console.WriteLine("3. Bài tập 3: Ma trận vuông cấp n");
                Console.WriteLine("4. Bài tập 4: Danh sách liên kết đơn (Tìm, Đếm, Xóa)");
                Console.WriteLine("5. Bài tập 5: Danh sách liên kết đơn (Thống kê tổng hợp)");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("Chọn bài tập (0-5): ");

                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1": ChayBai1(); break;
                    case "2": ChayBai2(); break;
                    case "3": ChayBai3(); break;
                    case "4": ChayBai4(); break;
                    case "5": ChayBai5(); break;
                    case "0": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            }
        }

        // ---------------- BÀI 1 ----------------
        static void ChayBai1()
        {
            Console.WriteLine("\n--- BÀI TẬP 1 ---");
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Dãy vừa nhập: ");
            HienThiMang(a);

            Console.Write("Nhập giá trị x cần chèn: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Nhập vị trí index k cần chèn (0 -> {a.Length}): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k > a.Length)
            {
                Console.WriteLine("Vị trí chèn không hợp lệ!");
                return;
            }

            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i < k; i++) tmp[i] = a[i];
            tmp[k] = x;
            for (int i = k; i < a.Length; i++) tmp[i + 1] = a[i];
            a = tmp;

            Console.Write("Dãy sau khi chèn: ");
            HienThiMang(a);
        }

        static void HienThiMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // ---------------- BÀI 2 ----------------
        static void ChayBai2()
        {
            Console.WriteLine("\n--- BÀI TẬP 2 ---");
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            NhanVien[] DS = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin nhân viên thứ {i + 1}:");
                Console.Write("Mã NV: "); DS[i].MaNV = Console.ReadLine();
                Console.Write("Họ và tên: "); DS[i].Hoten = Console.ReadLine();
                Console.Write("Năm sinh: "); DS[i].Namsinh = int.Parse(Console.ReadLine());
                Console.Write("Phòng ban: "); DS[i].Phongban = Console.ReadLine();
                Console.Write("Lương cơ bản: "); DS[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("Thưởng: "); DS[i].Thuong = int.Parse(Console.ReadLine());
            }

            // a. Tổng thực lĩnh tháng
            long tongThucLinh = 0;
            for (int i = 0; i < n; i++) tongThucLinh += DS[i].ThucLinh;
            Console.WriteLine($"\na. Tổng thực lĩnh của tất cả nhân viên: {tongThucLinh:N0}");

            // b. Danh sách nhân viên có lương cơ bản thấp nhất
            int minLuongCB = int.MaxValue;
            for (int i = 0; i < n; i++)
                if (DS[i].LuongCB < minLuongCB) minLuongCB = DS[i].LuongCB;

            Console.WriteLine($"\nb. Nhân viên có lương cơ bản thấp nhất ({minLuongCB:N0}):");
            for (int i = 0; i < n; i++)
                if (DS[i].LuongCB == minLuongCB)
                    Console.WriteLine($"   - {DS[i].MaNV} | {DS[i].Hoten} | Phòng: {DS[i].Phongban}");

            // c. Đếm nhân viên có mức thưởng >= 1200000
            int demThuong = 0;
            for (int i = 0; i < n; i++)
                if (DS[i].Thuong >= 1200000) demThuong++;
            Console.WriteLine($"\nc. Số lượng nhân viên có mức thưởng >= 1,200,000: {demThuong}");

            // d. Sắp xếp tăng dần theo phòng ban, trùng thì giảm dần theo mã NV
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int cmpPhong = string.Compare(DS[i].Phongban, DS[j].Phongban, StringComparison.OrdinalIgnoreCase);
                    bool canDoiCho = false;
                    if (cmpPhong > 0) canDoiCho = true;
                    else if (cmpPhong == 0 && string.Compare(DS[i].MaNV, DS[j].MaNV, StringComparison.OrdinalIgnoreCase) < 0)
                        canDoiCho = true;

                    if (canDoiCho)
                    {
                        NhanVien temp = DS[i];
                        DS[i] = DS[j];
                        DS[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nd. Danh sách sau khi sắp xếp (Phòng ban tăng dần, Mã NV giảm dần):");
            InBangNhanVien(DS, tangLuong: false);

            // e. Cập nhật tăng lương cơ bản lên 5% và in thông tin
            for (int i = 0; i < n; i++)
            {
                DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
            }
            Console.WriteLine("\ne. Danh sách sau khi cập nhật tăng lương cơ bản lên 5%:");
            InBangNhanVien(DS, tangLuong: true);
        }

        static void InBangNhanVien(NhanVien[] DS, bool tangLuong)
        {
            Console.WriteLine($"{"Mã NV",-8} | {"Họ Tên",-20} | {"Năm sinh",-8} | {"Phòng ban",-12} | {"Lương CB",-12} | {"Thưởng",-10} | {"Thực lĩnh",-12}");
            foreach (var nv in DS)
            {
                Console.WriteLine($"{nv.MaNV,-8} | {nv.Hoten,-20} | {nv.Namsinh,-8} | {nv.Phongban,-12} | {nv.LuongCB,-12:N0} | {nv.Thuong,-10:N0} | {nv.ThucLinh,-12:N0}");
            }
        }

        // ---------------- BÀI 3 ----------------
        static void ChayBai3()
        {
            Console.WriteLine("\n--- BÀI TẬP 3 ---");
            Console.Write("Nhập cấp n của ma trận vuông (0 < n < 100): ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMa trận vừa nhập:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write($"{a[i, j],5}");
                Console.WriteLine();
            }

            // a. Tính tổng tất cả phần tử
            int tong = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    tong += a[i, j];
            Console.WriteLine($"\na. Tổng tất cả phần tử của ma trận: {tong}");

            // b. Tìm giá trị dương nhỏ nhất
            int minDuong = int.MaxValue;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (a[i, j] > 0 && a[i, j] < minDuong)
                        minDuong = a[i, j];
            Console.WriteLine($"b. Giá trị dương nhỏ nhất: {(minDuong == int.MaxValue ? "Không có" : minDuong.ToString())}");

            // c. Tổng các phần tử nằm trên đường chéo phụ (j == n - 1 - i)
            int tongCheoPhu = 0;
            for (int i = 0; i < n; i++)
                tongCheoPhu += a[i, n - 1 - i];
            Console.WriteLine($"c. Tổng các phần tử trên đường chéo phụ: {tongCheoPhu}");

            // d. Kiểm tra đường chéo chính có tăng dần hay không
            int[] tg = new int[n];
            for (int i = 0; i < n; i++) tg[i] = a[i, i];

            bool tangDan = true;
            for (int i = 0; i <= n - 2; i++)
            {
                if (tg[i] >= tg[i + 1]) // Nếu không tăng dần chặt
                {
                    tangDan = false;
                    break;
                }
            }
            Console.WriteLine($"d. Đường chéo chính tăng dần: {tangDan}");
        }

        // ---------------- BÀI 4 ----------------
        static void ChayBai4()
        {
            Console.WriteLine("\n--- BÀI TẬP 4 ---");
            DanhSachLienKetDon list = new DanhSachLienKetDon();
            Console.Write("Nhập số lượng phần tử nguyên dương: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                int val = int.Parse(Console.ReadLine());
                list.ThemCuoi(val);
            }

            Console.Write("Danh sách ban đầu: ");
            list.XuatDanhSach();

            Console.Write("Nhập giá trị x cần đếm và xóa: ");
            int x = int.Parse(Console.ReadLine());

            // a. Đếm số phần tử bằng x
            Console.WriteLine($"a. Số lượng phần tử bằng {x}: {list.DemBangX(x)}");

            // b. Tìm phần tử dương nhỏ nhất
            int minDuong = list.TimMinDuong();
            Console.WriteLine($"b. Phần tử dương nhỏ nhất: {(minDuong == -1 ? "Không có" : minDuong.ToString())}");

            // c. Xóa phần tử x xuất hiện đầu tiên
            bool daXoa = list.XoaDauTienBangX(x);
            Console.WriteLine(daXoa ? $"c. Đã xóa phần tử {x} đầu tiên." : $"c. Không tìm thấy {x} để xóa.");
            Console.Write("Danh sách sau khi xóa: ");
            list.XuatDanhSach();
        }

        // ---------------- BÀI 5 ----------------
        static void ChayBai5()
        {
            Console.WriteLine("\n--- BÀI TẬP 5 ---");
            DanhSachLienKetDon l = new DanhSachLienKetDon();
            Console.Write("Nhập số lượng phần tử của danh sách: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                int val = int.Parse(Console.ReadLine());
                l.ThemCuoi(val);
            }

            Console.Write("Danh sách hiện tại: ");
            l.XuatDanhSach();

            // a. Phần tử lớn nhất
            Console.WriteLine($"a. Phần tử lớn nhất: {l.TimMax()}");

            // b. Tổng các phần tử
            Console.WriteLine($"b. Tổng các phần tử: {l.TinhTong()}");

            // c. Đếm số nguyên tố
            Console.WriteLine($"c. Số lượng số nguyên tố: {l.DemSoNguyenTo()}");

            // d. Đếm số âm, số 0, số dương
            l.DemAmDuongKhong(out int am, out int duong, out int khong);
            Console.WriteLine($"d. Số âm: {am} | Số bằng 0: {khong} | Số dương: {duong}");

            // e. Đếm số bằng x
            Console.Write("Nhập x cần đếm: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"e. Số lượng phần tử bằng {x}: {l.DemBangX(x)}");

            // f. Phần tử dương nhỏ nhất
            int minDuong = l.TimMinDuong();
            Console.WriteLine($"f. Phần tử dương nhỏ nhất: {(minDuong == -1 ? "Không có" : minDuong.ToString())}");
        }
    }
}