# Lập trình & Lắp ráp scene

> File này bám sát [`../HUONG_DAN_LAP_RAP.md`](../HUONG_DAN_LAP_RAP.md) ở thư mục gốc, và dùng 5 script trong [`Scripts_Mau/`](Scripts_Mau/). Khoảng 15–20 phút là bấm Play chơi được.

## 5 script cốt lõi (đã viết sẵn)

| Script | Gắn vào | Nhiệm vụ |
|---|---|---|
| `PlayerController.cs` | Player | Di chuyển 8 hướng + lướt (dash) |
| `PlayerCombat.cs` | Player | Chém cận chiến theo bán kính, sát thương quái |
| `Health.cs` | Player **và** Enemy | Máu, nhận sát thương, chết; có sự kiện cho UI |
| `EnemyAI.cs` | Enemy | Đứng yên → thấy Player thì đuổi → tới gần thì cắn |
| `CameraFollow.cs` | Main Camera | Bám theo Player mượt |

→ Chép cả 5 file từ `Scripts_Mau/` vào `Assets/Scripts/` của **project top-down** (vd `D:\Mygame_topdown\Assets\Scripts\`, KHÔNG phải project platformer `D:\Mygame2d`).

## Bước 0 — Điều kiện (đã làm ở giai đoạn 1)

- `Active Input Handling = Both` (Project Settings → Player).
- Có Layer tên **`Enemy`**.

Nếu chưa, quay lại [`../01_Bat_Dau_Cai_Dat/HUONG_DAN.md`](../01_Bat_Dau_Cai_Dat/HUONG_DAN.md) Bước 6.

## Bước 1 — Player

1. `GameObject → 2D Object → Sprites → Square`. Đổi tên **`Player`**.
2. Inspector:
   - **Tag = Player** (quan trọng — `EnemyAI` tìm người chơi qua tag này).
   - `Add Component → Rigidbody 2D` (không cần chỉnh — script tự đặt gravity = 0).
   - `Add Component → Box Collider 2D` (hoặc Capsule Collider 2D).
   - Kéo 3 script vào: **PlayerController**, **PlayerCombat**, **Health**.
3. Trong **PlayerCombat** → ô `Enemy Layer` → chọn **Enemy**.

## Bước 2 — Enemy (quái)

1. Tạo thêm Square, đổi tên **`Enemy`**, đổi màu (Sprite Renderer → Color → đỏ).
2. Inspector:
   - **Layer = Enemy** (góc trên phải, KHÔNG phải Tag).
   - `Add Component → Rigidbody 2D` + `Box Collider 2D`.
   - Kéo 2 script: **EnemyAI**, **Health** (đặt `Max Health = 60` cho dễ test).
3. Kéo `Enemy` từ Hierarchy xuống `Assets/Prefabs/` → thành **Prefab**. Sau này thả bao nhiêu con vào màn cũng được.

## Bước 3 — Camera

1. Chọn **Main Camera** → kéo script **CameraFollow** vào.
2. Kéo `Player` (từ Hierarchy) vào ô **Target**.

## Bước 4 — Chạy thử (Play)

| Phím | Hành động |
|---|---|
| WASD / mũi tên | Di chuyển 8 hướng |
| Space / Left Shift | Lướt (dash) |
| Chuột trái / J | Chém |

Quái đứng yên; thấy bạn trong vòng vàng (bật **Gizmos** để xem) thì đuổi; tới gần thì cắn. Chém đủ 3 phát (20 dmg × 3 ≥ 60 HP) là quái biến mất.

## Bước 5 — Kiểm tra lỗi biên dịch

**Luôn** mở **Console** (`Window → General → Console`) sau khi thêm/sửa script. Phải **không có lỗi đỏ** thì component mới dùng được. Nếu dùng Claude qua MCP, mình chạy `read_console` để kiểm tra giúp.

## Debug bằng Rider (kỹ năng đáng học sớm)

1. Trong Rider, đặt breakpoint (click lề trái) ở một dòng, vd trong `PlayerCombat.Attack()`.
2. Bấm **Attach to Unity Editor & Play** (biểu tượng con bọ + play).
3. Vào game bấm chuột trái — Rider dừng đúng dòng đó, xem được giá trị biến.

## Tinh chỉnh cảm giác (game feel)

Vào Inspector chỉnh số cho tới khi thấy "đã tay":
- `PlayerController`: `Move Speed`, `Dash Speed`, `Dash Cooldown`.
- `PlayerCombat`: `Attack Range`, `Damage`, `Attack Cooldown`.
- `EnemyAI`: `Sight Range`, `Move Speed`, `Attack Range`.
- `CameraFollow`: `Smooth Time` (nhỏ = bám sát, lớn = trôi mượt).

## Nối UI máu (bước đầu của giai đoạn 4)

`Health` có sự kiện `onDamaged(current, max)`. Tạo `Canvas → Slider`, rồi kéo hàm cập nhật Slider vào sự kiện `On Damaged` trong Inspector của Player → thanh máu tự chạy khi bị đánh.

---

➡️ Màn chạy được rồi? Sang [`../04_Hoan_Thien_Phat_Hanh/`](../04_Hoan_Thien_Phat_Hanh/README.md) để đánh bóng & build.
