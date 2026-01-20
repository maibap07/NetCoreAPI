## 1. Cấu trúc thư mục dự án ASP.NET MVC

Cấu trúc chính:

- Controllers/: Chứa các controller xử lý request từ trình duyệt
- Models/: Chứa các class dữ liệu (model)
- Views/: Chứa giao diện người dùng (.cshtml)
- wwwroot/: Chứa tài nguyên tĩnh (CSS, JS, Image)
- Program.cs: Cấu hình khởi động ứng dụng web
- *.csproj: File cấu hình project

Mô hình hoạt động theo mô hình MVC:
- Model: Dữ liệu
- View: Giao diện
- Controller: Xử lý logic

---

## 2. Route (Định tuyến) trong ASP.NET MVC

Route dùng để ánh xạ URL tới Controller và Action.

Route mặc định trong Program.cs:

Pattern:

{controller=Home}/{action=Index}/{id?}

## 3. Namespace trong C#

Namespace dùng để:
- Tổ chức code theo nhóm
- Tránh trùng tên class
- Dễ quản lý project lớn

