# 🎮 Bắt đầu từ đây — Lộ trình làm game

> Đây là "bản đồ" của cả dự án. Đọc file này trước, rồi đi lần lượt qua 4 thư mục hướng dẫn.

> ⚠️ **Bộ hướng dẫn này dành cho game TOP-DOWN Action RPG** (đi 8 hướng, lướt, chém cận chiến — theo `HUONG_DAN_LAP_RAP.md`). Đây là **Phương án B** trong [`KE_HOACH_MVP.md`](KE_HOACH_MVP.md), là một dự án **RIÊNG** — **KHÔNG** phải game platformer 2D đang chạy ở `D:\Mygame2d`. Hãy tạo một **project Unity mới** cho nó (đừng build đè lên platformer). Nếu muốn hoàn thành nhanh game đầu tiên, cân nhắc làm nốt platformer trước (xem `KE_HOACH_MVP.md`).

## Nguyên tắc số 1 (rút ra từ tài liệu nghiên cứu của bạn)

> **Bắt đầu NHỎ và HOÀN THÀNH.** Một game chơi được luôn giá trị hơn một game hoàn hảo chưa bao giờ ra mắt.

Bạn có một ý tưởng RPG lớn (đăng nhập, ví/vàng/kim cương, trang bị phân cấp tím–cam–đỏ, boss, PK, cổng dịch chuyển, lớp nhân vật…). **Tất cả sẽ được giữ lại** trong backlog, nhưng game ĐẦU TIÊN chỉ là một màn 2D nhỏ, chơi được, VUI. Xong cái nhỏ rồi mới mở rộng dần thành RPG.

## 4 giai đoạn = 4 thư mục

| Thư mục | Giai đoạn | Làm gì | Skill hỗ trợ |
|---|---|---|---|
| [`01_Bat_Dau_Cai_Dat/`](01_Bat_Dau_Cai_Dat/README.md) | **Chuẩn bị** | Cài Unity, dựng cấu trúc dự án, nối Unity MCP, chỉnh Input & Layer | `/game-bat-dau` |
| [`02_Ke_Hoach_GDD/`](02_Ke_Hoach_GDD/README.md) | **Kế hoạch** | Viết Game Design Document, chốt phạm vi bản v1, lưu backlog RPG | `/game-ke-hoach` |
| [`03_San_Xuat_Art_Code/`](03_San_Xuat_Art_Code/README.md) | **Sản xuất** | Làm art/asset + lập trình (dựng Player, Enemy, Camera, combat) | `/game-san-xuat` |
| [`04_Hoan_Thien_Phat_Hanh/`](04_Hoan_Thien_Phat_Hanh/README.md) | **Hoàn thiện** | Kiểm thử, đánh bóng (juice/VFX/SFX), build & phát hành | `/game-hoan-thien` |

## Thông tin dự án

- **Engine:** Unity 6 (6000.x), template **Universal 2D**, viết code bằng **Rider**.
- **Thể loại (bộ hướng dẫn này):** Game 2D Action RPG góc nhìn từ trên xuống (top-down).
- **Project top-down:** tạo **project Unity MỚI** (ví dụ `D:\Mygame_topdown`) — vì `D:\Mygame2d` hiện là game **platformer** khác, đừng trộn lẫn.
- **Unity MCP:** CoplayDev over HTTP cổng **8080** — sau khi tạo project top-down mới, bật MCP server trong project đó để Claude thao tác.
- **Thư mục tài liệu/kế hoạch:** chính là thư mục này (`làm_game`).

## 4 Skill gọi được (Claude Code)

Gõ trong Claude Code để mình tự động hoá từng giai đoạn:

- `/game-bat-dau` — kiểm tra & thiết lập môi trường Unity cho dự án mới.
- `/game-ke-hoach` — soạn/cập nhật GDD và backlog tính năng RPG.
- `/game-san-xuat` — dựng scene 2D (Player/Enemy/Camera + script) trong Unity qua MCP.
- `/game-hoan-thien` — chạy checklist kiểm thử và build game.

> Skill được cài ở cấp global (`~/.claude/skills/`) nên dùng được ở cả thư mục này lẫn khi bạn chạy Claude Code từ `D:\Mygame2d`.

## Tài liệu nền có sẵn ở thư mục gốc

- `README.md` — ghi chú ý tưởng RPG gốc của bạn.
- `Nghien cuu Phat trien Game 2D 3D.md` — tài liệu nghiên cứu quy trình 2D/3D (đọc mục 3 và mục 8).
- `HUONG_DAN_LAP_RAP.md` — hướng dẫn lắp ráp game 2D Action RPG từng bước (được thư mục `03` dùng lại).

## Bạn đang ở đâu? (đánh dấu tiến độ)

- [ ] Giai đoạn 1 — Môi trường đã sẵn sàng (Unity chạy, MCP nối được)
- [ ] Giai đoạn 2 — GDD bản v1 đã chốt
- [ ] Giai đoạn 3 — Màn chơi nhỏ đã dựng & di chuyển/chém được
- [ ] Giai đoạn 4 — Đã build ra file chơi được và chia sẻ cho người khác thử

Khi cả 4 ô đã tick → bạn đã HOÀN THÀNH game đầu tiên. Quay lại `02_Ke_Hoach_GDD/Y_Tuong_RPG_Day_Du.md` để chọn tính năng RPG tiếp theo.
