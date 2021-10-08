puts "please input book names: "
booknames = []

while name = gets.chomp
    break if name == 'exit'
    booknames << name
    puts "enter book name"  
end

p "book list"

booknames.each do |x|   
    x.capitalize!
end
p booknames.sort