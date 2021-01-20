/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 5.5.40 : Database - xust
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`xust` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `xust`;

/*Table structure for table `logs` */

DROP TABLE IF EXISTS `logs`;

CREATE TABLE `logs` (
  `gh` varchar(255) DEFAULT NULL,
  `msg` varchar(255) DEFAULT NULL,
  `timestamp` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `logs` */

insert  into `logs`(`gh`,`msg`,`timestamp`) values ('学号:17408070128 姓名:王子涵','打卡成功，时间为2020-12-15 17:15:04','2020-12-16'),('学号:17408070128 姓名:王子涵','success','2020-12-16'),('学号:17408070128 姓名:王子涵','success','2020-12-16');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `uid` varchar(255) DEFAULT NULL,
  `gh` varchar(50) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL,
  `in` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `user` */

insert  into `user`(`uid`,`gh`,`name`,`phone`,`in`) values ('https://ehallplatform.xust.edu.cn/default/jkdk/mobile/mobJkdkAdd_test.jsp?uid=MDgxNEUxNUJEMEI0QUY0NTE2MkExNDQ3RTQ2NTlEN0I=','17408070128','王子涵','13963410028','1');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
