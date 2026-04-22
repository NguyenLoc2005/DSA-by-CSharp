using System;

public class ReverseInteger {
    static void Main(string[] args) {
        int x = -12220;
        
        // In dấu trừ trước nếu là số âm
        if (x < 0) {
            Console.Write("-");
            x = -x;
        }

        int result = 0;
        while (x > 0) {
            int du = x % 10;          // Lấy chữ số cuối
            result = result * 10 + du; // Đẩy chữ số cũ sang trái và cộng số mới vào
            x = x / 10;                // Rút gọn x
        }

        Console.WriteLine(result); 
    }
}