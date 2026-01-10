-- =====================================================
-- Script: Kiểm tra dữ liệu cân độc lập trong bảng Weigh
-- Database: NhuaNong
-- Bảng: Weigh
-- =====================================================
-- 
-- KẾT LUẬN: KHÔNG CẦN TẠO THÊM BẢN GHI MỚI!
-- 
-- Agg1-5 đã tồn tại sẵn trong database với giá trị khởi tạo.
-- Chế độ cân độc lập (VanHanhInd) sẽ sử dụng:
--   - weighAGG1 -> Agg1
--   - weighAGG2 -> Agg2
--   - weighAGG3 -> Agg3
--   - weighAGG4 -> Agg4
--   - weighAGG5 -> Agg5
--
-- Sau khi lắp đặt hệ thống thực tế, mỗi phễu cân cần được
-- hiệu chuẩn riêng thông qua dialog "Sửa Cân" bằng cách
-- double-click vào phễu cân tương ứng.
-- =====================================================

USE NhuaNong;
GO

-- Kiểm tra dữ liệu hiện có
SELECT WeighID, WeighCode, WeighName, STT, Zero, Max, Offset, KLEmpty, TimeEmpty, WeiToVib, TON, TOFF
FROM Weigh 
WHERE WeighCode LIKE 'Agg%' OR WeighCode LIKE 'Ce%' OR WeighCode LIKE 'Wa%' OR WeighCode LIKE 'Add%'
ORDER BY STT;
