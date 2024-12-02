
window.AicsLogin = {
  windowEvents: {},
  AddWindowListener(obj) {
    /**
     * 监听键盘事件
     * @param e {KeyboardEvent}
     */
    const listeners = (e) => {
      obj.invokeMethodAsync("EnterKeyup", e.key)
    }
    window.addEventListener('keyup', listeners)
    this.windowEvents[obj] = listeners
  },
  RemoveWindowListener(obj) {
    window.removeEventListener('keyup', this.windowEvents[obj])
  },
};
