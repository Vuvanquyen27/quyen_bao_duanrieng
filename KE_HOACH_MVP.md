# Kế hoạch MVP — Từ ý tưởng RPG đến một game chơi được

> Mục tiêu của tài liệu này: biến tầm nhìn RPG lớn trong `README.md` thành một
> **MVP nhỏ, chơi được và HOÀN THÀNH được**, rồi mở rộng dần thành RPG.
> Nguyên tắc gốc (lấy từ `Nghien cuu Phat trien Game 2D 3D.md`):
> **"Bắt đầu nhỏ và HOÀN THÀNH. Một game chơi được luôn giá trị hơn một game
> hoàn hảo chưa bao giờ ra mắt."**

---

## 0. Điểm xuất phát thật (tình hình hiện tại)

Có 3 nguồn thông tin, và chúng đang "vênh" nhau — cần nhìn rõ để không lạc hướng:

| Nguồn | Nội dung | Trạng thái |
|-------|----------|-----------|
| `README.md` | Tầm nhìn **RPG online lớn**: đăng nhập, ví/xu/vàng/kim cương/lục bảo, trang bị đổi ngoại hình, đồ phân cấp màu (tím/cam/đỏ), fam boss, PK đồ sát, cổng dịch chuyển, class nhân vật | Mới là ý tưởng thô |
| `HUONG_DAN_LAP_RAP.md` | Hướng dẫn làm game **top-down action RPG** (5 script: PlayerController, PlayerCombat, Health, EnemyAI, CameraFollow) | Chưa dựng — là 1 game **khác** |
| `D:\Mygame2d` (Unity) | Một game **platformer 2D đã chạy được** | **Đã có sẵn, hoàn chỉnh vòng lặp cơ bản** |

**Game platformer đang có (trong `D:\Mygame2d\Assets\Scripts`):**

| Script | Vai trò |
|--------|---------|
| `PlayerMovement` | Đi trái/phải, nhảy, kiểm tra chạm đất, lật hướng |
| `CameraFollow` | Camera bám mượt (SmoothDamp) |
| `GameManager` | Đếm xu, hồi sinh khi rơi, xử lý thắng, HUD bằng OnGUI |
| `Coin` | Ăn xu → cộng điểm, biến mất |
| `Enemy` | Quái tuần tra qua lại, chạm player → hồi sinh player |
| `Goal` | Chạm đích → thắng |

→ Nói cách khác: **đã có một "vertical slice" platformer chạy được**. Đây là tài
sản quý nhất — nên tận dụng, không làm lại từ đầu.

---

## 1. Nguyên tắc chỉ đạo (đọc lại mỗi khi phân vân)

1. **Vertical slice trước:** làm 1 màn chơi trọn vẹn & VUI, hơn là 10 hệ thống dở dang.
2. **Mỗi bước phải "chơi được":** kết thúc mỗi giai đoạn, bấm Play là chơi được từ đầu đến cuối.
3. **Tái sử dụng > làm lại:** ghép tính năng RPG *lên trên* platformer đã có.
4. **Single-player trước, online sau (rất sau):** login/ví thật/PK/fam là mảng
   server — độ khó và chi phí tăng vọt. Chỉ đụng tới khi bản offline đã hoàn chỉnh.
5. **Test chơi thật sau mỗi giai đoạn**, chỉnh theo cảm giác chơi.

---

## 2. Quyết định nền tảng cần chốt: platformer hay top-down?

Đây là ngã rẽ lớn nhất — **quyết định một lần rồi gắn bó**:

- **Phương án A — Tiếp tục PLATFORMER (khuyến nghị cho MVP đầu tiên).**
  Ưu: đã chạy được → tới bản "chơi vui" nhanh nhất; tạo động lực sớm. Ghép chất
  RPG (tiền, đồ, class) dần lên trên. Hợp để **học và hoàn thành cái đầu tiên**.
- **Phương án B — Chuyển sang TOP-DOWN action RPG (theo `HUONG_DAN_LAP_RAP.md`).**
  Ưu: cảm giác "đánh quái, nhặt đồ, khám phá bản đồ" giống Genshin/RPG **gần với
  tầm nhìn README hơn**. Nhược: gần như làm lại từ đầu (điều khiển 8 hướng, đánh
  cận chiến, map top-down) → xa vạch đích hơn.

**Khuyến nghị:** làm **MVP bằng platformer đang có (Phương án A)** để hoàn thành
*một* game trước. Khi đã có 1 sản phẩm hoàn chỉnh và tự tin hơn, nếu vẫn muốn cảm
giác RPG top-down thì mở dự án 2 (Phương án B) — lúc đó kỹ năng đã đủ để không "vấp".

> Ghi chú: đây là *đề xuất*, không phải chốt cứng. Bạn là người quyết. Phần còn
> lại của kế hoạch viết theo Phương án A; nếu chọn B, khung giai đoạn vẫn dùng
> lại được, chỉ đổi phần "nền tảng" từ platformer sang top-down.

---

## 3. Phạm vi MVP v0.1 — "Một màn platformer VUI, trọn vẹn"

**Định nghĩa HOÀN THÀNH (Done):** mở game → có màn hình bắt đầu → chơi 1 màn được
thiết kế đàng hoàng → có thể thua và chơi lại → tới đích thì thắng. Không crash,
không lỗi console.

**CÓ trong MVP (IN scope):**
- [ ] 1 màn chơi *được thiết kế* bằng Tilemap (không phải vài hộp vuông trống).
- [ ] Máu/mạng cho người chơi (ví dụ 3 tim) — thay cho hồi sinh vô hạn.
- [ ] Ít nhất 1 loại quái **có thể hạ được** (giẫm đầu kiểu Mario, hoặc 1 đòn đánh).
- [ ] Xu → điểm (đã có), hiển thị HUD gọn (tim + xu).
- [ ] Màn hình **Start / Win / Game Over** + nút **Chơi lại**.
- [ ] Âm thanh cơ bản: nhảy, ăn xu, hạ quái, thắng.
- [ ] Tên game + biểu tượng tạm.

**KHÔNG trong MVP (OUT — để các phase sau):**
- Đăng nhập/mật khẩu, tài khoản, lưu trên server.
- Ví thật, kim cương, lục bảo, giao dịch.
- Nhiều class, đồ phân cấp màu, trang bị đổi ngoại hình.
- PK/đồ sát, fam boss, nhiều người chơi, cổng dịch chuyển giữa các map lớn.

---

## 4. Lộ trình theo giai đoạn (ghép ý tưởng RPG trong README vào từng phase)

Bảng dưới ánh xạ **từng tính năng mơ ước trong README** → làm ở phase nào, bản
tối giản ra sao. Ý tưởng lớn không bị bỏ — chỉ được **xếp hàng đúng thứ tự**.

| Tính năng (README) | Phase | Bản tối giản để bắt đầu |
|--------------------|:-----:|--------------------------|
| Di chuyển/nhảy, camera, quái, đích | 0 ✅ | **Đã xong** trong platformer hiện tại |
| Máu / hồi sinh có giới hạn | 1 | 3 tim; hết tim → Game Over |
| Đánh/hạ quái | 1 | Giẫm đầu quái (hoặc 1 đòn cận chiến) |
| Xu, tiền tệ thông thường | 1→2 | Xu đã có → gộp thành "vàng"; lưu điểm cao (PlayerPrefs) |
| Vật phẩm nhặt được | 2 | 1–2 loại: bình máu, chìa khóa mở cửa |
| Trang bị "mặc vào đổi ngoại hình" | 2→3 | 1 món đổi sprite/skill người chơi (chứng minh cơ chế) |
| Đồ phân cấp màu (tím/cam/đỏ) | 3 | Chỉ là chỉ số + màu viền; chưa cần online |
| Class nhân vật | 3 | 1–2 class khác nhau về 1 skill |
| Boss | 3 | 1 boss cuối màn, nhiều máu + 1–2 chiêu |
| Kim cương, lục bảo, ví | 4 | Chỉ khi có màn hình cửa hàng/kinh tế offline |
| Đăng nhập, tài khoản | 4 | ⚠️ Mảng server — làm sau cùng |
| PK/đồ sát, fam boss, nhiều người chơi | 4 | ⚠️ Online/multiplayer — chi phí lớn, làm sau cùng |
| Cổng dịch chuyển giữa map | 4 | Bản đơn giản: đổi scene tại chỗ đã làm được ở Phase 2 |

### Tóm tắt các phase

- **Phase 0 — Nền platformer.** ✅ *Đã xong.*
- **Phase 1 — "Màn chơi vui" (MVP v0.1).** Máu/mạng, hạ quái, Start/Win/Lose,
  1 màn Tilemap tử tế, âm thanh. → **Mục tiêu gần nhất, nên làm tiếp ngay.**
- **Phase 2 — "Chất RPG nhẹ".** Tiền tệ + lưu điểm, vật phẩm nhặt, trang bị đơn
  giản đổi ngoại hình, 2–3 màn nối nhau (chuyển cảnh = "cổng dịch chuyển" bản mini).
- **Phase 3 — "Nhân vật & thế giới".** Class, đồ phân cấp màu, 1 boss.
- **Phase 4 — "Mơ xa (chỉ khi nền đã vững)".** Ví/kim cương/lục bảo, đăng nhập,
  PK/fam, multiplayer. ⚠️ *Đây là bước nhảy về độ phức tạp — chỉ làm khi bản
  single-player đã thật sự vui và hoàn chỉnh.*

---

## 5. Việc làm tiếp ngay (khi bạn nói "làm tiếp")

Theo thứ tự finishable, mỗi việc ~nửa buổi, thuộc **Phase 1**:

1. **Máu/mạng:** thêm hệ thống 3 tim vào `GameManager` (hoặc script `PlayerHealth`
   mới); chạm quái/rơi vực → mất 1 tim; hết tim → Game Over.
2. **Hạ quái bằng giẫm đầu:** sửa `Enemy` để nếu player rơi trúng từ trên xuống
   thì quái chết + player nảy lên; chạm từ bên hông thì player mất tim.
3. **Màn hình Start / Win / Game Over + nút Chơi lại** (nâng OnGUI hiện tại lên
   Canvas UI, hoặc giữ OnGUI cho nhanh).
4. **Âm thanh:** thêm SFX nhảy, ăn xu, hạ quái, thắng.
5. **Thiết kế 1 màn Tilemap tử tế** thay các hộp vuông đặt tay.

> **Điều kiện để mình (Claude) thao tác trực tiếp trong Unity:** mở `D:\Mygame2d`
> trong Unity → `Window → MCP for Unity → Start Server` cho tới khi cổng 8080 lên.
> Hiện MCP báo **0 instance** (Unity chưa kết nối), nên các bước trên mình chưa
> thực thi trong engine được — mới dừng ở kế hoạch + viết/sửa file `.cs` trên đĩa.

---

## 6. Rủi ro & "phanh" cần nhớ

- **Bẫy MMORPG:** README mơ tới online/PK/fam — đó là mảng khó nhất ngành game.
  Đừng để nó kéo bạn rời khỏi việc hoàn thành bản offline nhỏ trước.
- **Bẫy làm-lại-từ-đầu:** đừng bỏ platformer đang chạy để nhảy sang top-down giữa
  chừng, trừ khi đã cân nhắc kỹ (mục 2).
- **Bẫy dở-dang:** làm xong *một* tính năng rồi mới sang tính năng kế tiếp.

---

## 7. Tiêu chí thành công của MVP v0.1 (checklist đo được)

- [ ] Người lạ cầm máy chơi được từ đầu đến cuối mà không cần hỏi.
- [ ] Có thắng và có thua rõ ràng; thua rồi chơi lại được ngay.
- [ ] Chơi 1 lượt trọn vẹn dưới ~3 phút và thấy **vui**.
- [ ] Console không còn error/warning khi Play.
- [ ] Bạn thấy tự hào đủ để cho bạn bè xem thử.

> Khi 5 ô trên đều tick → bạn đã HOÀN THÀNH game đầu tiên, và đi trước phần lớn
> người mới vẫn kẹt ở "học lý thuyết". Lúc đó mở Phase 2.
