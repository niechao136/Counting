
window.AicsLogin = {
  keyupEvent: {},
  AddWindowListener(obj, func) {
    /**
     * 监听键盘事件
     * @param e {KeyboardEvent}
     */
    const listeners = (e) => {
      obj.invokeMethodAsync(func, e.key || '')
    }
    window.addEventListener('keyup', listeners)
    this.keyupEvent[obj] = listeners
  },
  RemoveWindowListener(obj) {
    window.removeEventListener('keyup', this.keyupEvent[obj])
  },
};
window.AicsCommon = {
  /**
   * @param obj
   * @param element {HTMLElement}
   * @param func
   */
  GetElement(obj, element, func) {
    const ele = element.getBoundingClientRect()
    console.log(ele)
    const rect = {
      ...(ele || {}),
      windowWidth: innerWidth || document.documentElement.clientWidth,
      windowHeight: innerHeight || document.documentElement.clientHeight,
    }
    console.log(ele, rect)
    obj.invokeMethodAsync(func, rect)
  }
}
