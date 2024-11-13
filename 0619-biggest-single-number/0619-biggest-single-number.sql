

select Max(num)  as num from(select num from MyNumbers group by num having Count(num)=1) as num;