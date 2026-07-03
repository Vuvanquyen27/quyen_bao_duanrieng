# 03 · Sản xuất (Art + Code)

> Mục tiêu: từ bản thiết kế → thành một màn chơi thật sự bấm Play là chơi được. Đây là giai đoạn tốn công nhất, chia làm 2 nhánh song song: **Nghệ thuật (art)** và **Lập trình (code)**.

## Đọc gì trong thư mục này

- [`Art_Va_Asset.md`](Art_Va_Asset.md) — sprite, tileset/tilemap, animation; nguồn asset MIỄN PHÍ và công cụ vẽ.
- [`Lap_Trinh.md`](Lap_Trinh.md) — lắp ráp Player/Enemy/Camera và 5 script cốt lõi (bám theo `HUONG_DAN_LAP_RAP.md` ở gốc).
- [`Scripts_Mau/`](Scripts_Mau/) — 5 file `.cs` đã viết sẵn, chép thẳng vào `Assets/Scripts/` của Unity là dùng được.

## Thứ tự khuyến nghị (để chạy được nhanh nhất)

1. **Chép 5 script mẫu** trong `Scripts_Mau/` vào `Assets/Scripts/` của **project top-down** (vd `D:\Mygame_topdown\Assets\Scripts\` — KHÔNG phải project platformer `D:\Mygame2d`). Art dùng ô vuông tạm, thay sau.
2. **Dựng scene** theo `Lap_Trinh.md`: Player → Enemy → Camera → bấm Play.
3. Chơi thử: đi 8 hướng, lướt, chém quái. Quái đuổi theo và cắn.
4. **Khi đã chơi được rồi mới thay art thật** (`Art_Va_Asset.md`) — sprite, tilemap, animation.

> ⚠️ Sai lầm phổ biến của người mới: dành 2 tuần vẽ art trước khi có gì để chơi. Hãy làm cho **chơi được trước**, đẹp sau.

## Checklist giai đoạn 3

- [ ] 5 script đã ở trong `Assets/Scripts/` và **biên dịch không lỗi** (kiểm tra Console).
- [ ] Bấm Play: Player đi 8 hướng + lướt (Space/Shift) + chém (chuột trái/J).
- [ ] Quái thấy Player thì đuổi, tới gần thì cắn; chém đủ thì quái biến mất.
- [ ] Camera bám theo Player mượt.
- [ ] (Sau) đã thay ít nhất Player bằng sprite thật.
- [ ] (Sau) đã vẽ một màn nhỏ bằng Tilemap.

## Lối tắt

Gõ `/game-san-xuat` để mình dựng scene này trực tiếp trong Unity qua MCP (tạo GameObject, gắn script, set tag/layer, kiểm tra Console).

➡️ Xong giai đoạn này thì sang [`../04_Hoan_Thien_Phat_Hanh/`](../04_Hoan_Thien_Phat_Hanh/README.md).
