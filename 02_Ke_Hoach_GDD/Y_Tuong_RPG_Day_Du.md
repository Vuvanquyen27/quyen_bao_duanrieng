# Backlog RPG đầy đủ — từ ghi chú ý tưởng gốc

> Toàn bộ ý tưởng RPG lớn của bạn (trong `README.md`) được giữ ở đây, chia theo độ ưu tiên. **KHÔNG làm bây giờ.** Chỉ mở file này SAU KHI bản v1 (game nhỏ chơi được) đã xong. Mỗi lần lấy đúng 1 mục, làm xong, chơi thử, rồi mới lấy mục tiếp theo.

## 🟢 Đợt 1 — Ngay sau v1 (dễ, tăng độ vui nhanh)

- [ ] **Tiền tệ thường:** nhặt xu/vàng khi quái chết. Hiển thị số vàng trên UI.
- [ ] **Nhiều loại quái:** thêm 2–3 loại (nhanh–yếu, chậm–khoẻ, bắn xa).
- [ ] **Vật phẩm hồi máu:** rơi ra bình máu, nhặt để hồi.
- [ ] **Nhiều màn:** 2–3 màn nối tiếp, tăng độ khó.
- [ ] **Skill có cooldown (phím E):** một chiêu mạnh (vd đòn xoay, phóng chưởng).

## 🟡 Đợt 2 — Hệ thống RPG (vừa, cần thiết kế dữ liệu)

- [ ] **Trang bị (trang phục):** mặc đồ vào thì **đổi ngoại hình** nhân vật (đúng ghi chú của bạn).
- [ ] **Đồ phân cấp theo bậc:** đồ **tím → cam → đỏ** (độ hiếm tăng dần, chỉ số tăng dần).
- [ ] **Túi đồ (inventory):** UI ô đồ, nhặt/mặc/tháo/bán.
- [ ] **Chỉ số nhân vật:** máu, sát thương, tốc độ… thay đổi theo đồ đang mặc.
- [ ] **Lớp nhân vật (class):** vd cận chiến / pháp sư / xạ thủ — chiêu và chỉ số khác nhau.
- [ ] **Cổng dịch chuyển:** đi qua cổng để sang khu vực/màn khác.

## 🟠 Đợt 3 — Nội dung & thế giới (lớn, tốn công art + design)

- [ ] **Cốt truyện & kịch bản:** mạch truyện, hội thoại NPC.
- [ ] **Bối cảnh/khu vực theo "vũ trụ":** nhiều vùng đất với phong cách riêng.
- [ ] **Boss:** quái lớn nhiều pha (phase), thưởng đồ xịn (cam/đỏ).
- [ ] **Hiệu ứng nguyên tố (chất Genshin):** đòn lửa gây cháy theo thời gian, băng làm chậm…
- [ ] **Fam boss (đi theo nhóm săn boss).**

## 🔴 Đợt 4 — Trực tuyến & tài khoản (RẤT khó, cần backend/server)

> ⚠️ Đây là phần khó nhất và tốn kém nhất. Chỉ động tới khi game đã thực sự hay và bạn đã vững Unity. Cần server, cơ sở dữ liệu, bảo mật — một mảng riêng.

- [ ] **Đăng nhập & mật khẩu (tài khoản người chơi).**
- [ ] **Ví & tiền ảo:** vàng, kim cương, lục bảo — lưu trên server.
- [ ] **PK / đồ sát (đánh nhau giữa người chơi).**
- [ ] **Hiển thị tên:** tên **người chơi** hiện sẵn; tên **nhân vật** chỉ hiện khi click vào.
- [ ] **Nhiều người chơi cùng lúc (multiplayer/MMO).**

## Cách dùng backlog này

1. Bản v1 xong? → chọn **1 mục ở Đợt 1**.
2. Cập nhật `GDD.md` cho tính năng đó (nó ảnh hưởng gì tới core loop?).
3. Sang giai đoạn 03 làm, giai đoạn 04 kiểm thử & build lại.
4. Quay lại đây tick ✅ và chọn mục kế tiếp.

> Nguyên tắc vàng: **không nhảy thẳng xuống Đợt 4.** Đi tuần tự. Rất nhiều dự án chết vì cố làm "đăng nhập + multiplayer" trước khi có gameplay vui.
