%L(Farmer,Goose,Fox,Beans).

start([1,1,1,1]). %1 la co ben bo A, 0 khong co
goal([0,0,0,0]).

%Bieu dien trang thai ben bo A

%Trang thai nguy hiem
danger([[0,1,1,_],[0,1,_,1],[1,0,0,_],[1,0,_,0]]).

transition(X,Y):- operation(X,Y).

%Cho Ngong qua song
operation([1,1,Z,T],[0,0,Z,T]).
operation([0,0,Z,T],[1,1,Z,T]).

%Cho Cao qua song
operation([1,Y,1,T],[0,Y,0,T]).
operation([0,Y,0,T],[1,Y,1,T]).

%Cho beans qua song
operation([1,Y,Z,1],[0,Y,Z,0]).
operation([0,Y,Z,0],[1,Y,Z,1]).

%Nong dan qua lai
operation([1,Y,Z,T],[0,Y,Z,T]).
operation([0,Y,Z,T],[1,Y,Z,T]).

dfs(X,Y,[X|Y]):- goal(X).
dfs(X,Y,P):-
    transition(X,C),
    X \= C,
    \+member(C,Y),
    \+member(C,danger),
    %\+member(C,[ [0,1,1,_], [0,1,_,1], [1,0,0,_], [1,0,_,0] ]),
    dfs(C,[X|Y],P).
