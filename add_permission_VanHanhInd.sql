-- =============================================
-- Script thêm quyền "Vận Hành Cân Độc Lập" vào bảng SEC_Function
-- =============================================

-- Bước 1: Kiểm tra FunctionID cao nhất hiện có
SELECT MAX(FunctionID) AS MaxFunctionID FROM SEC_Function;

-- Bước 2: Thêm Function mới (thay đổi FunctionID nếu cần)
INSERT INTO SEC_Function (FunctionCode, FunctionName, MenuName, ParentID, FunctionType)
VALUES 
('VAN_HANH_IND', N'Vận Hành Cân Độc Lập', 'bbiVanHanhInd', NULL, 1);

-- Bước 3: Lấy FunctionID vừa thêm để gán quyền cho user/role
SELECT * FROM SEC_Function WHERE MenuName = 'bbiVanHanhInd';

-- Bước 4: Thêm quyền cho role (thay @RoleID bằng ID role cần gán)
-- DECLARE @NewFunctionID INT = (SELECT FunctionID FROM SEC_Function WHERE MenuName = 'bbiVanHanhInd');
-- INSERT INTO SEC_RoleFunction (RoleID, FunctionID) VALUES (@RoleID, @NewFunctionID);
