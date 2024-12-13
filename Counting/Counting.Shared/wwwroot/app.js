
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
   * 获取元素位置信息
   * @param obj
   * @param element {HTMLElement}
   * @param func
   * @param index {Number}
   */
  GetElement(obj, element, func, index = 0) {
    const ele = !!element && !!element.getBoundingClientRect ? element.getBoundingClientRect() : {}
    const rect = {
      windowWidth: innerWidth || document.documentElement.clientWidth,
      windowHeight: innerHeight || document.documentElement.clientHeight,
    }
    obj.invokeMethodAsync(func, Object.assign(ele, rect), index)
  },
  /**
   * 判断文本是否溢出
   * @param obj
   * @param element {HTMLElement}
   * @param func
   * @param index {Number}
   */
  IsTextOverflow(obj, element, func, index = 0) {
    let is_text_overflow = false
    if (!!element && element.clientWidth !== 0) {
      is_text_overflow = element.scrollWidth > element.clientWidth
    }
    obj.invokeMethodAsync(func, is_text_overflow, index)
  },
}
