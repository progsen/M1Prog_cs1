namespace SelectYourPower
{
    class DirectionalMover : IBulletMover
    {
        internal float dx, dy;
        public void MoveBullet(Bullet bullet, float frameTime)
        {
            bullet.gameObject.position.x += dx * bullet.speed * frameTime;
            bullet.gameObject.position.y += dy * bullet.speed * frameTime;
        }
    }
}