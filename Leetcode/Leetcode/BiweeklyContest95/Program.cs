Console.WriteLine("Hello World!");

public class DataStream {
    private readonly int _value;
    private readonly int _k;
    private List<int> nums;

    public DataStream(int value, int k) {
        _value = value;
        _k = k;
        nums = new List<int>();
    }
    
    public bool Consec(int num) {
        nums.Add(num);
        if (nums.Count < _k)
            return false;
        
        for(var i = nums.Count - 1; i >= nums.Count - _k; i--)
            if (nums[i] != _value)
            {
                return false;
            }

        return true;
    }
}