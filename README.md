# TestAssignment1CSharp

## Black Box Part:

ECP:

opdeling af tidsintervallerne giver følgende klasser:

1) 9:30 - 16:00

2) 16:00 - 19:30

3) 19:30 - 9:30 <- 

BV-test

test for billetpris 9:29 <-

test for billetpris 9:30

test for billetpris 9:31


test for billetpris 15:59

test for billetpris 16:00

test for billetpris 16:01

test for billetpris 19:29

test for billetpris 19:30

test for billetpris 19:31 <-

test for billetpris 21:00

metoden : public int ReturnerPrisBaseretPåTidsPkt(dateTime time){...}

ugyldige test:

inddata angivet i forkert format.

ikke initialiseret value

2)
mangler et angivet tidsinterval mellem 19:30 og 9:30,

hvornår bliver det rush-hour om morgenen


// yderligere info måske medtage en test for negativt tal
