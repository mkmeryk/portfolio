class FizzBuzz
    attr_accessor :number1, :number2

    def initialize(number1=0, number2=0)
        @number1, @number2 = number1, number2
    end


    def run
        a = Array.new
            for i in 1..100
                str = []
                str.push 'fizz' if i % @number1 == 0
                str.push 'buzz' if i % @number2 == 0
                str.push i if str.length == 0
                a << str.join('')
            end
        p a
    end

end

fb = FizzBuzz.new(3,5)
fb.run

fb.number1 = 2
fb.number2 = 3

fb.run

