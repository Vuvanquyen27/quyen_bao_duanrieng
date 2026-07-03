# Hướng dẫn lắp ráp — Game 2D Action RPG (top-down) trong Unity 6

Bộ script này dành cho **Unity 6 (6000.x)**, template **Universal 2D**. Mở code bằng **Rider** (đã cấu hình ở External Tools). Làm theo đúng thứ tự dưới đây, khoảng 15–20 phút là chạy được.

## Bước 0 — Cài đặt bắt buộc (làm trước, tránh lỗi)

1. Chép 5 file `.cs` vào thư mục `Assets/Scripts/` của project (kéo thả vào cửa sổ Project của Unity).
2. **Bật Input cũ:** `Edit → Project Settings → Player → Other Settings → Active Input Handling` → chọn **Both**. (Template mới của Unity mặc định chỉ bật Input System mới, sẽ báo lỗi `InvalidOperationException` khi chạy script này nếu không chỉnh.)
3. **Tạo Layer cho quái:** góc trên phải Inspector → `Layers → Edit Layers` → thêm layer tên `Enemy`.

## Bước 1 — Tạo nhân vật (Player)

1. `GameObject → 2D Object → Sprites → Square` (tạm dùng hình vuông, sau thay sprite thật). Đổi tên thành `Player`.
2. Trong Inspector:
   - Đặt **Tag = Player** (quan trọng — EnemyAI tìm người chơi qua tag này).
   - `Add Component → Rigidbody2D`. Không cần chỉnh gì — script tự đặt gravity = 0.
   - `Add Component → Box Collider 2D` (hoặc Capsule Collider 2D).
   - Kéo 3 script vào: **PlayerController**, **PlayerCombat**, **Health**.
3. Trong **PlayerCombat**, mục `Enemy Layer` → chọn **Enemy**.

## Bước 2 — Tạo quái (Enemy)

1. Tạo thêm một Square, đổi tên `Enemy`, đổi màu (chọn Sprite Renderer → Color → đỏ chẳng hạn).
2. Inspector:
   - Đặt **Layer = Enemy** (góc trên phải Inspector, KHÔNG phải Tag).
   - `Add Component → Rigidbody2D` và `Box Collider 2D`.
   - Kéo 2 script vào: **EnemyAI**, **Health** (chỉnh maxHealth = 60 cho dễ test).
3. Kéo Enemy từ Hierarchy xuống thư mục `Assets/Prefabs/` để tạo **Prefab** — sau này thả bao nhiêu con vào màn cũng được.

## Bước 3 — Camera

1. Chọn `Main Camera` → kéo script **CameraFollow** vào.
2. Kéo `Player` từ Hierarchy vào ô **Target**.

## Bước 4 — Chạy thử

Bấm **Play**:

| Phím | Hành động |
|------|-----------|
| WASD / mũi tên | Di chuyển 8 hướng |
| Space / Left Shift | Lướt (dash) |
| Chuột trái / J | Chém |

Quái sẽ đứng yên, thấy bạn trong tầm vàng (bật Gizmos để xem) thì đuổi theo, tới gần thì cắn. Chém đủ 3 phát (20 dmg × 3 ≥ 60 HP) là quái biến mất.

## Debug bằng Rider

1. Trong Rider, đặt breakpoint (click lề trái) ở dòng bất kỳ, ví dụ trong `PlayerCombat.Attack()`.
2. Bấm nút **Attach to Unity Editor & Play** (biểu tượng con bọ + play) trên thanh công cụ Rider.
3. Vào game bấm chuột trái — Rider sẽ dừng đúng dòng đó, xem được giá trị biến. Đây là kỹ năng đáng học sớm nhất.

## Gợi ý bước tiếp theo (đúng tinh thần "bắt đầu nhỏ" trong tài liệu của bạn)

1. **Sprite thật:** tải asset miễn phí trên itch.io hoặc Unity Asset Store (tìm "top down RPG sprites"), hoặc vẽ pixel art bằng Aseprite/Krita như tài liệu gợi ý.
2. **Tilemap:** `Window → 2D → Tile Palette` để vẽ màn chơi bằng tileset — khái niệm tilemap đã có trong mục 3.2 tài liệu của bạn.
3. **Animation:** cắt sprite sheet, tạo Animator với 4 hướng đi + chém.
4. **UI máu:** Canvas + Slider, móc vào sự kiện `onDamaged` của Health.
5. **"Chất Genshin":** thêm skill có cooldown (phím E), hiệu ứng nguyên tố (đòn lửa gây cháy theo thời gian), nhiều loại quái, rồi mới nghĩ tới boss.

> Nguyên tắc từ tài liệu: hoàn thành một màn chơi nhỏ mà VUI trước, rồi mới mở rộng. Một game chơi được luôn giá trị hơn một game hoàn hảo chưa bao giờ ra mắt.
