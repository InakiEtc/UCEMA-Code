function res= suma_mat(a,b)
  for i=1:3
    for j=1:4
      res(i,j) = a(i,j) + b(i,j);
    endfor
  endfor
endfunction
