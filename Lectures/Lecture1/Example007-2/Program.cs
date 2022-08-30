double firstSpeed = 5;
double secondSpeed = 10;
double dogSpeed = 20;
double distance = 1000;
bool place = true;
int count = 0;
while(distance > 10)
{
    if (place == true)
    {        
        distance = distance - (firstSpeed + secondSpeed) * distance / (secondSpeed + dogSpeed);
        place = false;
    }

    else
    {        
        distance = distance - (firstSpeed + secondSpeed) * distance / (firstSpeed + dogSpeed);
        place = true;
    }    

    count++;
}
Console.WriteLine(count);