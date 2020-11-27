Los ejemplos de video se encuentran en bin\debug. 
*Ahì se encuentra dirigida la ruta de la consola*

				*Resumen comandos*

Los formatos contenedores más populares son:

AVI (contenedor estándar de Windows)
MOV (contenedor estándar de Quicktime)
MP4 (contenedor estándar para MPEG-4)
Ogg (contenedor estándar de Xiph.org códecs)
MKV (Matroska, estándar abierto)

Opciones de audio:

– ar: frecuencia de sambleado del audio por segundo.
–acodec: codec de audio. Por ejemplo: wav, mp3, mp2, ac3… (si no te funciona mp3, prueba a poner: libmp3lame)
-ab: tasa de bits de audio por segundo (por defecto 64k).

Opciones de video

–vcodec: codec de video. Por ejemplo: mpeg4, copy, flv, wmv1, libxvid, etc. Para consultar todos los codecs disponibles puedes escribir en la consola: ffmpeg -formats.
r: Ajuste de velocidad de frames (número de ciclos por segundo (Hz), (por defecto = 25).
–s: tamaño del video. Por ejemplo: vga (640×480), svga (800×600)…
–b: tasa de bits de video por segundo (por defecto 200kbits por segundo). De este parámetro depende mucho la calidad del video y el tamaño.
–qscale 0: para obtener la misma calidad de video que el original.
–aspect: para fijar el aspect ratio (4:3, 16:9).

Otras opciones:

–i: nombre del fichero de entrada.
–pass: el número de veces que se va a recodificar el video (para conseguir una mayor compresión), por defecto 1.
–y: sobreescribir el fichero de salida.

copyright: https://www.adictosaltrabajo.com/2017/07/31/ffmpeg-para-edicion-video-funcionamiento-y-comandos/