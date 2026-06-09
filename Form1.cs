using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string fileMauPath = Path.Combine(Application.StartupPath, "BanRo_Mau.txt");

        public Form1()
        {
            InitializeComponent();
            rdbThucong.Checked = true;
            TaoFileMauMacDinh();

            // Cập nhật trạng thái các nút Tải file ngay khi vừa mở phần mềm
            CapNhatTrangThaiTaiFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BoGocControl(panel1, 30);
                BoGocControl(panel2, 30);
                BoGocControl(panel3, 30);

                BoGocControl(btnSinhKhoa, 15);
                BoGocControl(btnReset, 15);
                BoGocControl(btnChuyenKhoa, 15);
                BoGocControl(btnMoFileMaHoa, 15);
                BoGocControl(btnChuyenSangBanMa, 15);
                BoGocControl(btnLuuFileMaHoa, 15);
                BoGocControl(btnMoFileGiaiMa, 15);
                BoGocControl(btnGiaiMa, 15);
                BoGocControl(btnLuuFileGiaiMa, 15);
                BoGocControl(btnKiemTra, 15);

                BoGocControl(btnResetMaHoa, 15);
                BoGocControl(btnResetGiaiMa, 15);
            }
            catch { }
        }

      
        // HÀM TỰ ĐỘNG BẬT/TẮT NÚT TẢI FILE THEO CHẾ ĐỘ CHỌN
     
        private void CapNhatTrangThaiTaiFile()
        {
            if (rdbThucong.Checked)
            {
                // Nếu chọn thủ công: Khóa không cho bấm nút Tải file (Mở file)
                btnMoFileMaHoa.Enabled = false;
                btnMoFileGiaiMa.Enabled = false;

                // Có thể đổi màu nền mờ đi để người dùng dễ nhận biết nút đang bị khóa
                btnMoFileMaHoa.BackColor = Color.LightGray;
                btnMoFileGiaiMa.BackColor = Color.LightGray;
            }
            else
            {
                // Nếu chọn tự động: Mở khóa lại bình thường
                btnMoFileMaHoa.Enabled = true;
                btnMoFileGiaiMa.Enabled = true;

                // Khôi phục lại màu sắc ban đầu 
                btnMoFileMaHoa.BackColor = Color.Purple;
                btnMoFileGiaiMa.BackColor = Color.Purple;

                // Giữ lại chữ trắng 
                btnMoFileMaHoa.ForeColor = Color.White;
                btnMoFileGiaiMa.ForeColor = Color.White;
            }
        }

        // người dùng click thay đổi giữa Thủ công và Tự động
        private void rdbThucong_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatTrangThaiTaiFile();
        }

        private void TaoFileMauMacDinh()
        {
            try { if (!File.Exists(fileMauPath)) File.WriteAllText(fileMauPath, "Hello", Encoding.UTF8); } catch { }
        }

        private void BoGocControl(Control ctrl, int radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            ctrl.Region = new Region(gp);
        }

        private bool IsValidHexString(string hex)
        {
            foreach (char c in hex)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                    return false;
            }
            return true;
        }

        private byte[] HexStringToByteArray(string hex)
        {
            hex = hex.Replace("-", "").Replace(" ", "");
            if (hex.Length % 2 != 0) hex = hex.PadLeft(hex.Length + 1, '0');
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++) bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            return bytes;
        }

        private string ByteArrayToHexString(byte[] bytes)
        {
            StringBuilder hex = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes) hex.AppendFormat("{0:X2}", b);
            return hex.ToString();
        }

        private string EncryptDES(string plainText, byte[] keyBytes)
        {
            using (DES des = DES.Create())
            {
                des.Key = keyBytes;
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.PKCS7;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
                        cs.Write(inputBytes, 0, inputBytes.Length);
                        cs.FlushFinalBlock();
                    }
                    return ByteArrayToHexString(ms.ToArray());
                }
            }
        }

        private string DecryptDES(string cipherTextHex, byte[] keyBytes)
        {
            using (DES des = DES.Create())
            {
                des.Key = keyBytes;
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.PKCS7;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        byte[] cipherBytes = HexStringToByteArray(cipherTextHex);
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.FlushFinalBlock();
                    }
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }

        private void btnSinhKhoa_Click(object sender, EventArgs e)
        {
            using (DES des = DES.Create())
            {
                des.GenerateKey();
                txtKhoa.Text = ByteArrayToHexString(des.Key);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKhoa.Clear();
        }

        private void btnChuyenKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKhoa.Text))
            {
                MessageBox.Show("LỖI: Bạn chưa nhập hoặc chưa tạo khóa. Không thể chuyển khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtKhoa.Text.Length != 16)
            {
                MessageBox.Show("LỖI: Khóa hiện tại chưa hợp lệ (phải đúng 16 ký tự Hex). Không thể chuyển khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtKhoaBiMat.Text = txtKhoa.Text;
            MessageBox.Show("Đã chuyển khóa sang mục Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBanRo.Text))
                {
                    MessageBox.Show("Vui lòng nhập hoặc tải file bản rõ trước khi mã hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtKhoa.Text))
                {
                    MessageBox.Show("LỖI: Khóa mã hóa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtKhoa.Text.Length < 16 || !IsValidHexString(txtKhoa.Text))
                {
                    MessageBox.Show("Khóa chưa hợp lệ! Vui lòng nhập hoặc tạo khóa đủ 16 ký tự Hex.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] key = HexStringToByteArray(txtKhoa.Text.Substring(0, 16));
                txtBanMaMaHoa.Text = EncryptDES(txtBanRo.Text, key);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình mã hóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMoFileMaHoa_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK) txtBanRo.Text = File.ReadAllText(ofd.FileName);
        }

        private void btnChuyenSangBanMa_Click(object sender, EventArgs e)
        {
            txtBanMaGiaiMa.Text = txtBanMaMaHoa.Text;
        }

        private void btnLuuFileMaHoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBanMaMaHoa.Text)) return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK) File.WriteAllText(sfd.FileName, txtBanMaMaHoa.Text);
        }

        private void btnMoFileGiaiMa_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK) txtBanMaGiaiMa.Text = File.ReadAllText(ofd.FileName).Trim();
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBanMaGiaiMa.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc mở file bản mã trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtKhoaBiMat.Text))
            {
                MessageBox.Show("LỖI: Khóa bí mật dùng để giải mã không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtKhoaBiMat.Text.Length != 16 || !IsValidHexString(txtKhoaBiMat.Text))
            {
                MessageBox.Show("LỖI: Khóa bí mật phải nhập đúng 16 ký tự định dạng Hex hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtBanMaGiaiMa.Text.Length % 2 != 0 || !IsValidHexString(txtBanMaGiaiMa.Text))
            {
                txtBanRoGiaiMa.Clear();
                MessageBox.Show("LỖI: Chuỗi bản mã đã bị thay đổi cấu trúc! Định dạng mã Hex không hợp lệ (độ dài lẻ hoặc chứa ký tự lạ).", "Cảnh báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                byte[] key = HexStringToByteArray(txtKhoaBiMat.Text.Substring(0, 16));
                string ketQuaGiaiMa = DecryptDES(txtBanMaGiaiMa.Text, key);

                txtBanRoGiaiMa.Text = ketQuaGiaiMa;
                MessageBox.Show("Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CryptographicException)
            {
                txtBanRoGiaiMa.Clear();
                if (txtKhoa.Text != txtKhoaBiMat.Text)
                {
                    MessageBox.Show("LỖI: Giải mã thất bại! Khóa bí mật đã bị thay đổi, không trùng khớp với khóa gốc ban đầu.", "Cảnh báo bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("LỖI: Giải mã thất bại! Nội dung chuỗi bản mã đầu vào đã bị chỉnh sửa hoặc sai lệch dữ liệu.", "Cảnh báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giải mã thất bại do lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuFileGiaiMa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBanRoGiaiMa.Text)) return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK) File.WriteAllText(sfd.FileName, txtBanRoGiaiMa.Text, Encoding.UTF8);
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBanRo.Text) || string.IsNullOrEmpty(txtBanRoGiaiMa.Text))
            {
                MessageBox.Show("Không thể kiểm tra chéo! Vui lòng hoàn thành đầy đủ cả quy trình Mã hóa và Giải mã trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtBanRo.Text == txtBanRoGiaiMa.Text)
            {
                MessageBox.Show("Kết quả trùng khớp!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("LỖI: Kết quả không khớp! Bản rõ đã bị thay đổi hoặc chỉnh sửa!.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetMaHoa_Click(object sender, EventArgs e)
        {
            txtBanRo.Clear();
            txtBanMaMaHoa.Clear();
            txtBanRo.Focus();
        }

        private void btnResetGiaiMa_Click(object sender, EventArgs e)
        {
            txtBanMaGiaiMa.Clear();
            txtKhoaBiMat.Clear();
            txtBanRoGiaiMa.Clear();
            txtBanMaGiaiMa.Focus();
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void txtKhoaBiMat_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
    }
}
