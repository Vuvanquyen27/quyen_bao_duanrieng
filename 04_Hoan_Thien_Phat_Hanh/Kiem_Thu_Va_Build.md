# Kiểm thử, Đánh bóng & Build

> Giai đoạn biến "màn chơi được" thành "game đáng chơi" và xuất ra file cho người khác thử.

## Phần 1 — Kiểm thử (Playtest / QA)

### Tự kiểm thử
- [ ] Chơi trọn màn từ đầu đến khi thắng/thua **ít nhất 5 lần**.
- [ ] Thử phá game: đi vào tường, spam nút chém, lướt liên tục, đứng yên cho quái đánh.
- [ ] Ghi lại mọi **bug chặn** (crash, kẹt, không thắng được) và sửa trước.

### Nhờ người khác chơi (quan trọng nhất)
- Đưa game cho 1–2 người **không nói gì cả**, chỉ quan sát.
- Họ có hiểu phải làm gì không? Chỗ nào họ lúng túng? Có thấy vui không?
- Đừng cãi lại phản hồi — ghi lại và cân nhắc. (Tài liệu nghiên cứu: "lặp lại dựa trên phản hồi".)

## Phần 2 — Đánh bóng (Polish / "Juice")

Hiệu ứng không chỉ để đẹp — nó là **phản hồi** cho người chơi. Vài thứ rẻ mà hiệu quả cao:

- [ ] **UI thanh máu** cho Player (Canvas → Slider, móc vào `Health.onDamaged`).
- [ ] **Âm thanh:** chém, trúng đòn, quái chết, nhạc nền. Tải miễn phí:
  - <https://freesound.org> (hiệu ứng), <https://opengameart.org> (nhạc), Kenney có gói SFX.
- [ ] **Hiệu ứng hình ảnh khi trúng đòn:** nhân vật chớp trắng, văng vài hạt (Particle System).
- [ ] **Rung camera nhẹ (screen shake)** khi chém trúng — cảm giác "đã" hơn hẳn.
- [ ] **Màn hình thắng / thua** rõ ràng (Game Over, You Win + nút chơi lại).

> Nguyên tắc: gameplay không đổi, nhưng thêm juice làm game "lên đời". Làm sau khi đã chơi được, đừng làm trước.

## Phần 3 — Tối ưu cơ bản

- [ ] Console **không còn lỗi đỏ và ít cảnh báo vàng** (`read_console` để kiểm tra).
- [ ] Không tạo/hủy object liên tục mỗi frame (với đạn/quái số lượng lớn → object pooling, để sau).
- [ ] Ảnh sprite đặt đúng Sprite Mode, tắt Read/Write nếu không cần.

## Phần 4 — Build (xuất file chơi được)

1. `File → Build Settings` (Unity 6: có thể là `File → Build Profiles`).
2. **Add Open Scenes** để thêm màn `Main` vào danh sách build.
3. Chọn nền tảng:
   - **Windows** — file `.exe` gửi bạn bè chạy trực tiếp.
   - **WebGL** — chơi trên trình duyệt, hợp để đăng itch.io. (Cần đã cài WebGL Build Support ở giai đoạn 1.)
4. **Build** → chọn thư mục trống → chờ Unity đóng gói.
5. Chạy thử file build (không phải Editor) để chắc chắn nó hoạt động độc lập.

## Phần 5 — Phát hành lên itch.io (miễn phí)

1. Tạo tài khoản tại <https://itch.io>.
2. **Dashboard → Create new project.**
3. Với WebGL: nén thư mục build thành `.zip`, upload, tick **"This file will be played in the browser"**.
4. Viết mô tả ngắn, thêm 1–2 ảnh chụp màn hình, đặt giá = **Free**.
5. Đăng ở chế độ *Draft/Restricted* trước, gửi link cho bạn bè thử, rồi mới *Public*.

## 🎉 Xong v1!

Bạn vừa **hoàn thành** một game — điều mà phần lớn người "học lý thuyết mãi" chưa làm được.

**Tiếp theo:** mở [`../02_Ke_Hoach_GDD/Y_Tuong_RPG_Day_Du.md`](../02_Ke_Hoach_GDD/Y_Tuong_RPG_Day_Du.md), chọn **1 tính năng ở Đợt 1**, rồi lặp lại vòng: cập nhật GDD (02) → làm (03) → kiểm thử & build (04). Cứ thế, game nhỏ dần lớn thành RPG.
