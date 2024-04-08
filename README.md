## Ecommerce BookStore
Trang web Thương mại điện tử bán sách cho khách hàng có thể xem thông tin cuốn sách và với trang Bảng điều khiển cung cấp cho người quản trị toàn quyền kiểm soát sách và danh mục.

## Sử Dụng
- Razor Pages và Page Models để tạo các view cần thiết cho ứng dụng
- Entity Framework kết hợp với code first migrations
- SQL Server
- Authentication and Authorization với Quản lý vai trò để hạn chế/cho phép người dùng truy cập vào các tài nguyên cụ thể trong ứng dụng
- Seeding Data vào cơ sở dữ liệu

## Chức năng
- Trang chủ: có thể truy cập bởi tất cả người dùng, hiển thị danh sách các sách với tiêu đề, tác giả và giá.
- Trang Chi tiết sách: có thể truy cập bởi tất cả người dùng, hiển thị thông tin chi tiết về một cuốn sách được chọn.
- Trang Mua sách: có thể truy cập bởi Khách hàng, cho phép họ mua sách với số lượng mong muốn.
- Trang Admin: chỉ có thể truy cập bởi Admin, cho phép họ thêm, sửa, xóa sách và quản lý các danh mục.
- Tất cả các chức năng dựa trên vai trò chỉ có sẵn cho người dùng đã được xác thực. Bạn sẽ được chuyển hướng đến trang đăng nhập nếu cố gắng truy cập các trang/chức năng không được phép.
