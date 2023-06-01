function trayectorian(mat,n,nod1,nod2)
  mataux = mat;
  for i + 1:n-1
    mataux = prod_booleano(mataux,mat);
  endfor
  if mataux(nod1,nod2) == 1
    fprintf("Existe tray. de longitud %d entre los nodos %d y %d \n",n,nod1,nod2)
  else
    fprintf("NO existe tray. de longitud %d entre los nodos %d y %d \n",n,nod1,nod2)
  endif

