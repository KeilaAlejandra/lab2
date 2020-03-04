CREATE TABLE video(
idVideo int primary key,
titulo varchar (100),
repro int,
url varchar(100)
);

CREATE PROCEDURE sp_video_insertar
	@idVideo int,
	@titulo varchar(100),
	@repro int,
	@url varchar(100)
as
begin
	INSERT INTO video
	VALUES(@idVideo,@titulo,@repro,@url)
end

EXEC sp_video_insertar 1,'Video',1,'x'

drop procedure SP_video_ACTUALIZAR

CREATE PROCEDURE SP_video_ACTUALIZAR
@idVideo int,
@titulo varchar(100),
@repro int,
@url varchar(100)
AS
BEGIN
UPDATE video SET titulo= @titulo, repro = @repro, url = @url WHERE idVideo = @idVideo 
END
EXEC SP_video_ACTUALIZAR 1, 'mau', 3, 'felipo' 

SELECT * FROM video