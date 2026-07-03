# Game Design Document — Bản v1 (MVP)

> Đây là bản thiết kế **ngắn** cho game ĐẦU TIÊN. Cố tình giữ nhỏ để hoàn thành được. Sửa thẳng vào file này cho hợp ý bạn.

## 1. Tổng quan

| Mục | Nội dung |
|---|---|
| **Tên tạm** | (điền tên bạn thích, vd: "Lữ Khách") |
| **Thể loại** | Action RPG 2D, góc nhìn từ trên xuống (top-down) |
| **Nền tảng** | PC (Windows) + WebGL (chơi trên trình duyệt) |
| **Engine** | Unity 6, Universal 2D, C# |
| **Người làm** | 1 người (bạn) + AI trợ lý |
| **Câu một dòng** | "Một chiến binh khám phá vùng đất bị quái vật chiếm, chém đường máu qua từng khu." |

## 2. Vòng lặp cốt lõi (Core loop)

> Đây là "trái tim" của game — thứ người chơi làm đi làm lại. Với bản v1 giữ THẬT đơn giản:

**Đi khám phá → Gặp quái → Chém hạ quái → Nhặt thưởng → Đi tiếp → Tới cuối màn (thắng).**

Nếu vòng lặp này VUI khi chỉ có ô vuông chạy quanh, thì game sẽ hay khi thêm art. Nếu nó chán, đừng thêm tính năng — hãy chỉnh cảm giác điều khiển/đánh nhau trước.

## 3. Nhân vật

### Người chơi (Player) — bản v1
- Di chuyển 8 hướng, có kỹ năng **lướt (dash)** để né.
- Đòn đánh cận chiến (chém quanh mình).
- Có máu (Health). Hết máu = thua.

### Quái (Enemy) — bản v1
- **1 loại quái** duy nhất: đứng yên, thấy người chơi trong tầm thì đuổi, tới gần thì cắn.
- Có máu; chém đủ thì chết.

> Lớp nhân vật, fam, boss, PK… (ghi trong ý tưởng gốc) → để ở backlog, KHÔNG làm bản v1.

## 4. Cơ chế (Mechanics) — bản v1

| Cơ chế | Có ở v1? | Ghi chú |
|---|---|---|
| Di chuyển 8 hướng | ✅ | `PlayerController` |
| Lướt/né (dash) | ✅ | có cooldown |
| Đánh cận chiến | ✅ | `PlayerCombat`, sát thương theo bán kính |
| Máu & chết | ✅ | `Health` (dùng chung Player/Enemy) |
| AI quái đuổi & cắn | ✅ | `EnemyAI` |
| Camera bám nhân vật | ✅ | `CameraFollow` |
| Nhặt thưởng (xu/vàng) | ⏳ v1.1 | thêm sau khi màn chạy được |
| Trang bị & phân cấp đồ | ❌ backlog | RPG lớn |
| Đăng nhập/ví/kim cương | ❌ backlog | cần backend, để rất sau |
| Boss / PK / cổng dịch chuyển | ❌ backlog | RPG lớn |

## 5. Màn chơi (Level) — bản v1

- **Một màn nhỏ** (`Main.unity`): một khu vực vẽ bằng Tilemap, đặt vài con quái (dùng Prefab).
- Điều kiện **thắng**: hạ hết quái / tới được điểm cuối màn.
- Điều kiện **thua**: máu Player về 0.

## 6. Phong cách nghệ thuật (Art style)

- Bản đầu: **ô vuông màu** (placeholder) — không vẽ gì cả, để test gameplay.
- Sau khi chơi được: pixel art đơn giản (tải asset miễn phí hoặc vẽ bằng Aseprite/Krita). Chi tiết ở `../03_San_Xuat_Art_Code/Art_Va_Asset.md`.

## 7. Âm thanh

- Bản v1: 2–3 hiệu ứng (chém, trúng đòn, quái chết) + 1 nhạc nền lặp. Tải miễn phí (xem giai đoạn 4).

## 8. Phạm vi v1 (MVP) — GẠCH ĐẦU DÒNG PHẢI LÀM

Đây là "hợp đồng" với chính mình. **Chỉ làm những gạch này, không hơn**, cho tới khi build được:

- [ ] Player đi 8 hướng + lướt + chém.
- [ ] 1 loại quái biết đuổi & cắn, có máu.
- [ ] Health dùng chung, chết thì biến mất.
- [ ] Camera bám Player.
- [ ] 1 màn nhỏ có vài con quái, có điều kiện thắng/thua.
- [ ] Thanh máu Player (UI).
- [ ] Build ra file chơi được.

Khi 7 ô này xong → **v1 HOÀN THÀNH**. Ăn mừng, rồi mới mở backlog.

## 9. Lộ trình mở rộng (sau v1)

Xem [`Y_Tuong_RPG_Day_Du.md`](Y_Tuong_RPG_Day_Du.md). Mỗi lần chỉ thêm **1 tính năng**, chơi thử, rồi mới thêm cái tiếp theo.
