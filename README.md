# Gestor de tránsito vehicular - Programación Orientada a Objetos

## Introducción
En este ejercicio se emplean las siguientes técnicas:
- Herencia de clases
- Encapsulamiento
- Delegados
- Sobrecarga de operadores

## Consignas
- Desarrolle una clase abstracta Vehiculo que exponga los atributos Nombre (string), Avanzando (bool, lectura pública y escritura privada) y Velocidad (int, abstracto). - _HECHO_
- Desarrolle las clases Auto, Ambulancia, Moto y Colectivo. Las cuatro heredarán de Vehiculo. Auto tendrá los atributos Cilindrada (int) y Deportivo (bool). Moto tendrá los atributos Cilindrada (int) y Tipo (enumerado: Scooter, Enduro, GranTurismo). Colectivo tendrá el atributo Pasajeros (int) y DoblePiso (bool), Ambulancia tendrá un atributo EnEmergencia (bool). - _HECHO_
- Los Autos avanzarán a razón de 30 km/h por 1000 cc de cilindrada (Ej: Cilindrada de 2000 avanza a 60). Los Auto deportivos alcanzarán una velocidad un 40% mayor. Las Motos avanzarán a 70 si tienen menos de 500 cc de cilindrada y a 80 si tienen más. Si es un Scooter avanzará a la mitad de esa velocidad, una enduro a esa velocidad y una Gran Turismo al doble de esa velocidad. Los Colectivos avanzarán a 50 si tienen una capacidad mayor a 100 personas y a 80 si tienen menor capacidad. Las Ambulancias siempre avanzarán a 100. - _HECHO_
- Todos los vehículos que No estén avanzando devolverán una velocidad de cero. Los vehículos siempre se instanciarán avanzando. - _HECHO_
- Desarrolle la clase Transito que encapsule (no exponga) una colección de vehículos. Expondrá un método Agregar que recibirá un vehículo como parámetro. - _HECHO_
- Desarrolle una interfaz de usuario que permita listar al menos dos vehículos de cada tipo mostrando su nombre y las diferentes velocidades (para distinguirlo en la grilla escriba el nombre del Vehículo indicando el tipo y su característica, ej: MotoEnduro600). - _HECHO_

### Opcionales:
- Transito expondrá un método PonerSemaforoRojo que disparará un delegado o evento que detendrá todos los vehículos. Los vehículos detenidos devolverán una velocidad de cero. Las ambulancias que estén en emergencia no se detendrán ante un semáforo rojo. - _HECHO_
- Vehiculo tendrá un atributo Marca que se podrá leer de forma pública y escribir dentro del mismo Assembly. Todos los vehículos serán marca Chevrolet que se asignará al ser agregados al tránsito. La marca se mostrará en la grilla también. - _HECHO_
- A los Colectivos se les podrá sumar un entero, resultando en un Colectivo con una capacidad en de pasajeros equivalente a la capacidad del primer Colectivo más el entero sumado. Ej: Colectivo mColectivo = mOtroColectivo + 5; - _HECHO_
- Implemente la interfaz IUtilitario que exponga el atributo Matricula (sting). Los Colectivos y las Ambulancias serán utilitarios. Si se agrega un vehículo utilitario al tránsito (identifique la ésto por la interfaz, no por la clase derivada) se disparará un evento UtilitarioCirculando con argumentos personalizados que permitirá mostrar la matrícula. Ese evento será capturado en el formulario y en una Lista aparte se mostrará el listado de matrículas.
- Transito soportará clonación profunda.
- Transito expondrá un método ListarVehiculosRapidos que devolverá la lista de los vehículos que avancen a más de 90km/h. Dicha lista se generará con Linq
- La clase Moto no permitirá que la hereden. La clase Ambulancia no permitirá que vuelvan a sobreescribir Velocidad.
