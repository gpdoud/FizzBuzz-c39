
for(int idx = 1; idx <= 30; idx++) {

    bool isDivBy3 = (idx % 3 == 0) ? true : false;

    bool isDivBy5 = (idx % 5 == 0) ? true : false;

    bool isDivBy3n5 = isDivBy3 && isDivBy5;

    //==========================================//

    if (isDivBy3n5) {
        Console.Write(" FIZZBUZZ ");
        continue;
    }

    if(isDivBy3) {
        Console.Write(" FIZZ ");
        continue;
    }
    if(isDivBy5) {
        Console.Write(" BUZZ ");
        continue;
    }

    Console.Write($" {idx} ");

}