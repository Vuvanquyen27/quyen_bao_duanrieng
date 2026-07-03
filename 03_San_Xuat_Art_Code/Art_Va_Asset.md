# Nghệ thuật & Asset (2D)

> Quy tắc: **làm cho chơi được TRƯỚC (dùng ô vuông), làm đẹp SAU.** Đừng vẽ art khi chưa có gì để chơi.

## 1. Ba khái niệm 2D phải nắm

| Khái niệm | Là gì | Trong Unity |
|---|---|---|
| **Sprite** | Ảnh 2D của nhân vật/vật thể | kéo ảnh `.png` vào `Assets/Art/Sprites/`, đặt Texture Type = *Sprite (2D and UI)* |
| **Tileset** | Bộ "gạch" nhỏ để ghép thành màn | ảnh chia lưới đều; Sprite Mode = *Multiple*, dùng Sprite Editor cắt |
| **Tilemap** | Hệ thống xếp gạch thành môi trường | `GameObject → 2D Object → Tilemap`, vẽ bằng `Window → 2D → Tile Palette` |

## 2. Nguồn asset MIỄN PHÍ (dùng ngay, chất lượng tốt)

| Nguồn | Link | Ghi chú |
|---|---|---|
| **Kenney** | <https://kenney.nl/assets> | Cực hợp người mới, CC0 (dùng thoải mái), có bộ top-down RPG |
| **itch.io (free game assets)** | <https://itch.io/game-assets/free> | Lọc "top down", "RPG", "pixel" |
| **OpenGameArt** | <https://opengameart.org> | Kho lớn, chú ý đọc giấy phép từng asset |
| **Unity Asset Store (Free)** | <https://assetstore.unity.com> | Lọc giá = Free, import thẳng vào project |

> ⚠️ Luôn kiểm tra **giấy phép (license)**. CC0 = dùng tự do kể cả thương mại. Một số asset yêu cầu ghi công tác giả (credit).

## 3. Tự vẽ (nếu thích)

| Công cụ | Dùng cho | Giá |
|---|---|---|
| **Aseprite** | Pixel art + animation sprite (chuẩn ngành indie) | ~5$ (hoặc tự build miễn phí) |
| **Krita** | Vẽ tự do, số hoá | Miễn phí |
| **Piskel** | Pixel art trên trình duyệt | Miễn phí, online |

Bắt đầu: vẽ nhân vật **16×16** hoặc **32×32** pixel. Nhỏ = nhanh, dễ animate.

## 4. Pipeline art cho bản v1 (thứ tự làm)

1. **Thay Player trước:** tải/ vẽ 1 sprite nhân vật → kéo vào Sprite Renderer của Player (thay ô vuông).
2. **Thay Enemy:** tương tự, đổi màu/sprite cho dễ phân biệt.
3. **Vẽ màn bằng Tilemap:** tải 1 tileset → tạo Tilemap → mở Tile Palette → tô nền, tường.
4. **Va chạm cho tường:** thêm `Tilemap Collider 2D` (+ `Composite Collider 2D`) lên lớp tường để nhân vật không đi xuyên.
5. **Animation (nâng cao):** cắt sprite sheet → tạo Animator với các trạng thái *Idle / Walk (4 hướng) / Attack*.

## 5. Hoạt ảnh (Animation) — làm khi đã quen

- `Window → Animation → Animation` để tạo clip từ nhiều sprite.
- `Animator` (máy trạng thái) chuyển giữa Idle ↔ Walk ↔ Attack dựa trên tham số (vd `Speed`, trigger `Attack`).
- Kết nối với code: trong `PlayerController`/`PlayerCombat`, gọi `animator.SetFloat("Speed", ...)`, `animator.SetTrigger("Attack")`.

## 6. Chiếu sáng 2D (Universal 2D) — điểm nhấn cuối

Template Universal 2D có sẵn 2D lighting. Thêm `GameObject → Light → 2D → Global Light 2D` để chỉnh sáng tối cả cảnh; thêm `Point Light 2D` cho đuốc/hiệu ứng. Làm ở bước đánh bóng (giai đoạn 04), không phải bây giờ.

---

➡️ Phần code lắp ráp: xem [`Lap_Trinh.md`](Lap_Trinh.md).
