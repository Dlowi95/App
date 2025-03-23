using App.Models;

namespace App.Services;

public class PlanetService : List<PlanetModel> {
    public PlanetService (){
        Add(new PlanetModel() {
            Id = 1,
            Name = "Mercury",
            VnName = "Sao Thuỷ",
            Content = "là nhỏ nhất và gần nhất trong tám thuộc , với bằng khoảng 88 . Nhìn từ Trái Đất, hành tinh hiện lên với trên quỹ đạo bằng xấp xỉ 116 ngày, và nhanh hơn hẳn những hành tinh khác. Tốc độ chuyển động nhanh này đã khiến người La Mã đặt tên hành tinh là , vị thần liên lạc và đưa tin một cách nhanh chóng. Trong tên của vị thần này là (Ερμής). Tên của hành tinh này dựa theo tên do Trung Quốc đặt, chọn theo hành trong ."
        });
        Add(new PlanetModel() {
            Id = 2,
            Name = "Venus",
            VnName = "Sao Kim",
            Content = "là thứ 2 trong , tự quay quanh nó với chu kỳ khoảng 243 ngày . Xếp sau , nó là thiên thể tự nhiên sáng nhất trong bầu trời tối, với bằng −4.6, đủ sáng để tạo nên bóng trên mặt nước. Bởi vì Sao Kim là hành tinh phía trong tính từ , nó không bao giờ xuất hiện trên bầu trời mà quá xa : góc đạt cực đại bằng 47,8°. Sao Kim đạt độ sáng lớn nhất ngay sát thời điểm hoàng hôn hoặc bình minh, do vậy mà còn gọi là sao Hôm, khi hành tinh này hiện lên lúc , và sao Mai, khi hành tinh này hiện lên lúc ."
        });
        Add(new PlanetModel() {
            Id = 3,
            Name = "Earth",
            VnName = "Trái Đất",
            Content = "Hello Earth."
        });
        Add(new PlanetModel() {
            Id = 4,
            Name = "Mars",
            VnName = "Sao Hoả",
            Content = "Hello Mars."
        });
        Add(new PlanetModel() {
            Id = 5,
            Name = "Jupiter",
            VnName = "Sao Mộc",
            Content = "Hello Jupiter."
        });
        Add(new PlanetModel() {
            Id = 6,
            Name = "Saturn",
            VnName = "Sao Thổ",
            Content = "Hello Saturn."
        });
        Add(new PlanetModel() {
            Id = 7,
            Name = "Uranus",
            VnName = "Sao Thiên Vương",
            Content = "Hello Uranus."
        });
        Add(new PlanetModel() {
            Id = 8,
            Name = "Neptune",
            VnName = "Sao Hải Vương",
            Content = "Hello Neptune."
        });
    }
}