%3,7,9 dong 5

start([0,0,0]).
goal([5,_,_]).
goal([_,5,_]).
goal([_,_,5]).

transition(X,Y):- operation(X,Y).

operation([_,X,Y],[3,X,Y]). %Full binh 1
operation([X,_,Y],[X,7,Y]). %Full binh 2
operation([X,Y,_],[X,Y,9]).

operation([_,X,Y],[0,X,Y]). %Empty binh 1
operation([X,_,Y],[X,0,Y]). %Empty binh 2
operation([X,Y,_],[X,Y,0]).

%Binh 1 sang 2
operation([X,Y,Z],[A,B,Z]):- X+Y =<7, A is 0, B is X+Y.
operation([X,Y,Z],[A,B,Z]):- X+Y>7, A is X-7+Y, B is 7.

%Binh 2 sang 1
operation([X,Y,Z],[A,B,Z]):- X+Y =<3, A is X+Y, B is 0.
operation([X,Y,Z],[A,B,Z]):- X+Y>3, A is 3,B is Y-3+X.


%Binh 2 sang 3
operation([X,Y,Z],[X,A,B]):- Y+Z =<9, A is 0, B is Y+Z.
operation([X,Y,Z],[X,A,B]):- Y+Z>9, A is Y-9+Z, B is 9.

%Binh 3 sang 2
operation([X,Y,Z],[X,A,B]):- Y+Z =<7, A is Y+Z, B is 0.
operation([X,Y,Z],[X,A,B]):- Y+Z>7, A is 7, B is Z-7+Y.

%Binh 1 sang 3
operation([X,Y,Z],[A,Y,B]):- X+Z =<9, A is 0, B is X+Z.
operation([X,Y,Z],[A,Y,B]):- X+Z>9, A is X-9+Z, B is 9.

%Binh 3 sang 1
operation([X,Y,Z],[A,Y,B]):- X+Z =<3, A is X+Z, B is 0.
operation([X,Y,Z],[A,Y,B]):- X+Z>3, A is 3, B is Z-3+X.


dfs(X,Y,[X|Y]):-goal(X).
dfs(X,Y,P):-
    transition(X,C),
    X \= C,
    \+member(C,Y),
    dfs(C,[X|Y],P).

