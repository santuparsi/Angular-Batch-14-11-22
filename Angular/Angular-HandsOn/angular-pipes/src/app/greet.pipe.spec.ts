import { GreetPipe } from './greet.pipe';

describe('GreetPipe', () => {
  it('create an instance', () => {
    const pipe = new GreetPipe();
    expect(pipe).toBeTruthy();
  });
});
