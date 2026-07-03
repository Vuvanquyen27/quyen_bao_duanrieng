# Hướng dẫn chi tiết — Bắt đầu & Cài đặt

Làm theo đúng thứ tự. Khoảng 30–45 phút (chủ yếu là chờ tải Unity).

---

## Bước 1 — Cài Unity 6

1. Tải **Unity Hub** tại <https://unity.com/download> và cài đặt.
2. Trong Unity Hub → tab **Installs** → **Install Editor** → chọn phiên bản **Unity 6 (6000.x LTS)**.
3. Ở phần **Add modules**, tick thêm:
   - **WebGL Build Support** (để sau xuất bản lên itch.io chơi trên trình duyệt).
   - **Windows Build Support** (thường có sẵn).
4. Chờ tải & cài (vài GB).

> Vì sao Unity? Theo tài liệu nghiên cứu của bạn: Unity mạnh nhất về đa nền tảng và 2D trưởng thành (Hollow Knight, Celeste, Cuphead đều làm bằng Unity). C# dễ học hơn C++.

## Bước 2 — Tạo project MỚI cho game top-down

> ⚠️ `D:\Mygame2d` đang là game **platformer** khác. Đừng mở/ghi đè lên nó. Hãy tạo một project riêng cho game top-down này.

- Unity Hub → **New project** → template **Universal 2D** → đặt tên (vd `Mygame_topdown`), chọn thư mục `D:\`.

> Template **Universal 2D** đã cấu hình sẵn URP 2D (chiếu sáng 2D, pipeline nhẹ) — đúng cho game top-down.

## Bước 3 — Đặt Rider làm trình soạn code

1. Cài **JetBrains Rider** (miễn phí cho mục đích học/không thương mại, hoặc bản dùng thử).
2. Trong Unity: `Edit → Preferences → External Tools → External Script Editor` → chọn **Rider**.
3. (Rider giúp gợi ý code, bắt lỗi sớm, và **debug** bằng breakpoint — kỹ năng đáng học sớm nhất.)

## Bước 4 — Dựng cấu trúc thư mục trong `Assets/`

Trong cửa sổ **Project** của Unity, tạo các thư mục con của `Assets/` (chuột phải → Create → Folder):

```
Assets/
├── Scripts/     ← code C# (.cs)
├── Prefabs/     ← vật thể tái sử dụng (Enemy, đạn, item…)
├── Art/
│   ├── Sprites/ ← ảnh nhân vật, vật thể
│   └── Tiles/   ← tileset để vẽ màn
├── Scenes/      ← các màn chơi (Main.unity…)
└── Audio/       ← nhạc & hiệu ứng âm thanh
```

Cấu trúc gọn từ đầu = sau này không loạn.

## Bước 5 — Nối Unity MCP (để Claude điều khiển Editor)

**Unity MCP (CoplayDev)** chạy over HTTP cổng **8080**. Cần bật MCP server **trong project top-down mới** vừa tạo (không phải project platformer cũ).

1. Mở project top-down trong Unity (Editor phải đang **mở** thì MCP mới nói chuyện được).
2. Bật MCP: `Window → MCP for Unity → Start Server` cho tới khi cổng 8080 lên và có instance kết nối.
3. Kiểm tra từ Claude Code: gõ `/game-bat-dau` — mình sẽ đọc trạng thái Editor (scene đang mở, có đang compile không…). Đọc được nghĩa là kết nối OK.

> Mẹo: chạy Claude Code **từ thư mục project top-down** khi làm việc trực tiếp với Unity, để MCP tự pin đúng instance.

## Bước 6 — Hai chỉnh sửa BẮT BUỘC (tránh lỗi khi chạy script)

1. **Bật Input cũ (Legacy Input):**
   `Edit → Project Settings → Player → Other Settings → Active Input Handling` → chọn **Both**.
   *(5 script mẫu ở giai đoạn 3 dùng `Input.GetAxisRaw`/`Input.GetMouseButton`. Template mới mặc định chỉ bật Input System mới → sẽ báo `InvalidOperationException` nếu không đổi.)*

2. **Tạo Layer cho quái:**
   Góc trên phải Inspector → `Layers → Edit Layers…` → ở một ô **User Layer** trống, gõ tên **`Enemy`**.
   *(PlayerCombat dùng layer này để biết chém trúng ai.)*

## Xong! Kiểm tra lại

Tick hết checklist trong [`README.md`](README.md). Nếu mọi thứ OK → sang **giai đoạn 2 (Kế hoạch & GDD)**.

## Gỡ lỗi thường gặp

| Triệu chứng | Nguyên nhân & cách sửa |
|---|---|
| Script báo `InvalidOperationException` về Input | Chưa đặt Active Input Handling = **Both** (Bước 6.1). |
| PlayerCombat không đánh trúng quái | Chưa tạo Layer `Enemy` hoặc quái chưa gán layer đó. |
| Claude không đọc được Editor | Unity chưa mở, hoặc MCP chưa lắng nghe cổng 8080. Mở lại Unity. |
| Nhân vật rơi xuống dưới | Rigidbody2D còn trọng lực — script tự đặt `gravityScale = 0`, đảm bảo đã gắn `PlayerController`. |
