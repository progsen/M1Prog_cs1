namespace SelectYourPower
{
    class StraightBulletMover : IBulletMover
    {
        public void MoveBullet(Bullet bullet, float frameTime)
        {
            bullet.gameObject.position.x += bullet.speed * frameTime;
        }
    }
}