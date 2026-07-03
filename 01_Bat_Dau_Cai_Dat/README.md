# 01 · Bắt đầu & Cài đặt (Chuẩn bị)

> Mục tiêu: sau giai đoạn này, mở Unity là chạy được, Claude nối được vào Editor qua MCP, và dự án có cấu trúc gọn gàng để không rối về sau.

## Đọc gì trong thư mục này

- [`HUONG_DAN.md`](HUONG_DAN.md) — hướng dẫn chi tiết từng bước: cài Unity, dựng cấu trúc thư mục, nối Unity MCP, chỉnh Input & Layer.

## Checklist giai đoạn 1

- [ ] Đã cài **Unity Hub** và **Unity 6 (6000.x LTS)**.
- [ ] Đã tạo project **MỚI** template **Universal 2D** cho game top-down (vd `D:\Mygame_topdown`) — KHÔNG dùng `D:\Mygame2d` (đó là platformer khác).
- [ ] Đã đặt **Rider** làm External Script Editor.
- [ ] Cấu trúc thư mục `Assets/` đã có: `Scripts/`, `Prefabs/`, `Art/`, `Scenes/`, `Audio/`.
- [ ] **Unity MCP** kết nối OK (cổng 8080) — Claude đọc được trạng thái Editor.
- [ ] `Active Input Handling = Both` (Project Settings → Player).
- [ ] Đã tạo **Layer** tên `Enemy`.

## Lối tắt

Gõ `/game-bat-dau` trong Claude Code để mình kiểm tra tự động những mục trên và chỉ ra cái nào còn thiếu.

➡️ Xong giai đoạn này thì sang [`../02_Ke_Hoach_GDD/`](../02_Ke_Hoach_GDD/README.md).
