# Buổi 02 – DanhSach

Họ tên: Nguyễn Duy Thành · MSV: 12425097

## Bài đã làm
Bài 1, Bài 2, Bài 3, Bài 4, Bài 5


## Kết quả chạy


--- BÀI TẬP 1 ---

Nhập số phần tử n: 4

Nhập a[0]: 10

Nhập a[1]: 20

Nhập a[2]: 30

Nhập a[3]: 40

Dãy vừa nhập: 10 20 30 40 

Nhập giá trị x cần chèn: 99

Nhập vị trí index k cần chèn (0 -> 4): 2

Dãy sau khi chèn: 10 20 99 30 40 





----------------------------------------------------------------

2. BÀI TẬP 2: QUẢN LÝ DANH SÁCH NHÂN VIÊN (STRUCT)

----------------------------------------------------------------

Chọn bài tập (0-5): 2



--- BÀI TẬP 2 ---

Nhập số lượng nhân viên: 3



Nhập thông tin nhân viên thứ 1:

Mã NV: NV01

Họ và tên: Nguyen Van An

Năm sinh: 1998

Phòng ban: IT

Lương cơ bản: 10000000

Thưởng: 1500000



Nhập thông tin nhân viên thứ 2:

Mã NV: NV02

Họ và tên: Tran Thi Binh

Năm sinh: 2000

Phòng ban: Ke Toan

Lương cơ bản: 8000000

Thưởng: 1000000



Nhập thông tin nhân viên thứ 3:

Mã NV: NV03

Họ và tên: Le Hoang Cuong

Năm sinh: 1999

Phòng ban: IT

Lương cơ bản: 8000000

Thưởng: 2000000



a. Tổng thực lĩnh của tất cả nhân viên: 30,500,000



b. Nhân viên có lương cơ bản thấp nhất (8,000,000):

   - NV02 | Tran Thi Binh | Phòng: Ke Toan

   - NV03 | Le Hoang Cuong | Phòng: IT



c. Số lượng nhân viên có mức thưởng >= 1,200,000: 2



d. Danh sách sau khi sắp xếp (Phòng ban tăng dần, Mã NV giảm dần):

Mã NV    | Họ Tên               | Năm sinh | Phòng ban    | Lương CB     | Thưởng     | Thực lĩnh   

NV03     | Le Hoang Cuong       | 1999     | IT           | 8,000,000    | 2,000,000  | 10,000,000  

NV01     | Nguyen Van An        | 1998     | IT           | 10,000,000   | 1,500,000  | 11,500,000  

NV02     | Tran Thi Binh        | 2000     | Ke Toan      | 8,000,000    | 1,000,000  | 9,000,000   



e. Danh sách sau khi cập nhật tăng lương cơ bản lên 5%:

Mã NV    | Họ Tên               | Năm sinh | Phòng ban    | Lương CB     | Thưởng     | Thực lĩnh   

NV03     | Le Hoang Cuong       | 1999     | IT           | 8,400,000    | 2,000,000  | 10,400,000  

NV01     | Nguyen Van An        | 1998     | IT           | 10,500,000   | 1,500,000  | 12,000,000  

NV02     | Tran Thi Binh        | 2000     | Ke Toan      | 8,400,000    | 1,000,000  | 9,400,000   





----------------------------------------------------------------

3. BÀI TẬP 3: MA TRẬN VUÔNG CẤP N

----------------------------------------------------------------

Chọn bài tập (0-5): 3



--- BÀI TẬP 3 ---

Nhập cấp n của ma trận vuông (0 < n < 100): 3

a[0,0] = 1

a[0,1] = -2

a[0,2] = 4

a[1,0] = 0

a[1,1] = 5

a[1,2] = 6

a[2,0] = 7

a[2,1] = 8

a[2,2] = 9



Ma trận vừa nhập:

    1   -2    4

    0    5    6

    7    8    9



a. Tổng tất cả phần tử của ma trận: 38

b. Giá trị dương nhỏ nhất: 1

c. Tổng các phần tử trên đường chéo phụ: 16

d. Đường chéo chính tăng dần: True





----------------------------------------------------------------

4. BÀI TẬP 4: DANH SÁCH LIÊN KẾT ĐƠN (TÌM, ĐẾM, XÓA)

----------------------------------------------------------------

Chọn bài tập (0-5): 4



--- BÀI TẬP 4 ---

Nhập số lượng phần tử nguyên dương: 5

Nhập phần tử thứ 1: 4

Nhập phần tử thứ 2: 7

Nhập phần tử thứ 3: 2

Nhập phần tử thứ 4: 7

Nhập phần tử thứ 5: 9

Danh sách ban đầu: 4 -> 7 -> 2 -> 7 -> 9 -> null

Nhập giá trị x cần đếm và xóa: 7

a. Số lượng phần tử bằng 7: 2

b. Phần tử dương nhỏ nhất: 2

c. Đã xóa phần tử 7 đầu tiên.

Danh sách sau khi xóa: 4 -> 2 -> 7 -> 9 -> null





----------------------------------------------------------------

5. BÀI TẬP 5: DANH SÁCH LIÊN KẾT ĐƠN (THỐNG KÊ TỔNG HỢP)

----------------------------------------------------------------

Chọn bài tập (0-5): 5



--- BÀI TẬP 5 ---

Nhập số lượng phần tử của danh sách: 6

Nhập phần tử thứ 1: -5

Nhập phần tử thứ 2: 0

Nhập phần tử thứ 3: 2

Nhập phần tử thứ 4: 7

Nhập phần tử thứ 5: 4

Nhập phần tử thứ 6: 7

Danh sách hiện tại: -5 -> 0 -> 2 -> 7 -> 4 -> 7 -> null

a. Phần tử lớn nhất: 7

b. Tổng các phần tử: 15

c. Số lượng số nguyên tố: 3

d. Số âm: 1 | Số bằng 0: 1 | Số dương: 4

Nhập x cần đếm: 7

e. Số lượng phần tử bằng 7: 2

f. Phần tử dương nhỏ nhất: 2
