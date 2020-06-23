goal([0,0,3,3,0]).
start([3,3,0,0,1]).

danger([A,B,C,D,_]):- A>=B, C>=D.
danger([A,B,0,_,_]):- A>=B.
danger([0,_,A,B,_]):- A>=B.

% di chuyen 2 nha su
operation([X,Y,Z,T,1],[A,Y,C,T,0]):- X>1, A is X-2, C is Z+2.
operation([X,Y,Z,T,0],[A,Y,C,T,1]):- Z>1, A is X+2, C is Z-2.

% di chuyen 2 quy
operation([X,Y,Z,T,1],[X,B,Z,D,0]):- Y>1, B is Y-2, D is T+2.
operation([X,Y,Z,T,0],[X,B,Z,D,1]):- T>1, B is Y+2, D is T-2.

% di chuyen 1 nguoi 1 quy
operation([X,Y,Z,T,1],[A,B,C,D,0]):- X>0, Y>0, A is X-1, B is Y-1, C is Z+1, D is T+1.
operation([X,Y,Z,T,0],[A,B,C,D,1]):- X<3, Y<3, A is X+1, B is Y+1, C is Z-1, D is T-1.

% di chuyen 1 nha su
operation([X,Y,Z,T,1],[A,Y,C,T,0]):- X>0, A is X-1, C is Z+1.
operation([X,Y,Z,T,0],[A,Y,C,T,1]):- Z>0, A is X+1, C is Z-1.

% di chuyen 1 quy
operation([X,Y,Z,T,1],[X,B,Z,D,0]):- Y>0, B is Y-1, D is T+1.
operation([X,Y,Z,T,0],[X,B,Z,D,1]):- T>0, B is Y+1, D is T-1.

trans(X,Y):-operation(X,Y), X \= Y.

dfs(X,Y,[X|Y]):- goal(X).
dfs(X,Y,P):-
    trans(X,C),
    \+member(C,Y),
    danger(C),
    dfs(C,[X|Y],P).